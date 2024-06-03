using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreSystem {
    internal class StoreBackend {

        struct StoreItem {
        public string name;
        public int price;
        public int count;
        public Dictionary<string, string> attributes;
        public StoreItem(string name, int price, int count, Dictionary<string, string> attributes) {
            this.name = name;
            this.price = price;
            this.count = count;
            this.attributes = attributes;
            }
        }

        private static readonly string FILEPATH = "db.csv";
        private Dictionary<int, StoreItem> itemList;
        public StoreBackend() {
            itemList = new Dictionary<int, StoreItem>();
            ReadFile();
        }
        ~StoreBackend() {
            WriteFile(itemList);
        }
        private void ReadFile() {
            if (File.Exists(FILEPATH)) {
                using (StreamReader sr = new StreamReader(FILEPATH)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        string[] values = line.Split(',');
                        Dictionary<string, string> attributes = new Dictionary<string, string>();
                        attributes.Add(values[4], values[5]);
                        for (int i = 6; i < values.Length; i++) {
                            attributes.Add(values[i], values[++i]);
                        }
                        itemList.Add(int.Parse(values[0]), new StoreItem(values[1], int.Parse(values[2]), int.Parse(values[3]), attributes));
                    }
                }
            } else {
                InitializeFile();
            }
        }
        private void WriteFile(Dictionary<int, StoreItem> itemList) {
            using (FileStream fs = File.Create(FILEPATH))  //Overwrites the file
            using (StreamWriter sw = new StreamWriter(fs)) {
                foreach (int key in itemList.Keys) {
                    string allAtributes = "";
                    foreach (string attribute in itemList[key].attributes.Keys) {
                        allAtributes += string.Format(",{0},{1}", attribute, itemList[key].attributes[attribute]);
                    }
                    sw.WriteLine(string.Format("{0},{1},{2},{3}{4}",//allAtributes comes with its own , at the start hencer 3 and 4 can "touch".
                        key, itemList[key].name, itemList[key].price, itemList[key].count, allAtributes));
                }
            }
        }
        /* initializeFILE explanation.
         * This will make and POPULATE the csv file. In a real world scenario the populating of the CSV file makes no sense upon system start 
         * if the file is missing. But because the assignment required some elements to be sold this will add those specific elements while also
         * making it easy for me to delete the file to restart the database for debugging purposes.
         * A *real world implementation* would just make the file, leave it empty, and have the people responsible of the store add the items manually.
         */
        private void InitializeFile() {
            Dictionary<int, StoreItem> populateList = new Dictionary<int, StoreItem>() {
                //BOOKS
                {1, new StoreItem("Bello Gallico et Civili", 449, 1, new Dictionary<string, string>() {
                        {"type", "book"},
                        {"author", "Julius Caesar"},
                        {"genre", "history"},
                        {"format", "bound"},
                        {"language", "latin"}
                })},
                {2, new StoreItem("How to Read a Book", 149, 1, new Dictionary<string, string>() {
                        {"type", "book"},
                        {"author", "Mortimer J. Adler"},
                        {"genre", "course literature"},
                        {"format", "pocket"}
                })},
                {3, new StoreItem("Moby Dick", 49, 1, new Dictionary<string, string>() {
                        {"type", "book"},
                        {"author", "Herman Melville"},
                        {"genre", "adventure"},
                        {"format", "pocket"}
                })},
                {4, new StoreItem("Great Gatsby", 79, 1, new Dictionary<string, string>() {
                        {"type", "book"},
                        {"author", "F. Scott Fitzgerald"},
                        {"genre", "noir"},
                        {"format", "e-Book"}
                })},
                {5, new StoreItem("House of Leaves", 49, 1, new Dictionary<string, string>() {
                        {"type", "book"},
                        {"author", "Mark Z. Danielewski"},
                        {"genre", "horror"}
                })},
                //GAMES
                {6, new StoreItem("Elden Ring", 599, 1, new Dictionary<string, string>() {
                        {"type", "game"},
                        {"platform", "Playstation 5"}
                })},
                {7, new StoreItem("Demon's Souls", 499, 1, new Dictionary<string, string>() {
                        {"type", "game"},
                        {"platform", "Playstation 5"}
                })},
                {8, new StoreItem("Microsoft Flight Simulator", 499, 1, new Dictionary<string, string>() {
                        {"type", "game"},
                        {"platform", "PC"}
                })},
                {9, new StoreItem("Planescape Torment", 99, 1, new Dictionary<string, string>() {
                        {"type", "game"},
                        {"platform", "PC"}
                })},
                {10, new StoreItem("Disco Elysium", 399, 1, new Dictionary<string, string>() {
                        {"type", "game"},
                        {"platform", "PC"}
                })},
                //MOVIES
                {11, new StoreItem("Nyckeln till frihet", 99, 1, new Dictionary<string, string>() {
                        {"type", "movie"},
                        {"format", "DVD"},
                        {"playtime", "142 min"}
                })},
                {12, new StoreItem("Gudfadern", 99, 1, new Dictionary<string, string>() {
                        {"type", "movie"},
                        {"format", "DVD"},
                        {"playtime", "152 min"}
                })},
                {13, new StoreItem("Konungens återkomst", 199, 1, new Dictionary<string, string>() {
                        {"type", "movie"},
                        {"format", "Blu-Ray"},
                        {"playtime", "154 min"}
                })},
                {14, new StoreItem("Pulp fiction", 199, 1, new Dictionary<string, string>() {
                        {"type", "movie"},
                        {"format", "Blu-Ray"}
                })},
                {15, new StoreItem("Schindlers list", 99, 1, new Dictionary<string, string>() {
                        {"type", "movie"},
                        {"format", "DVD"}
                })}
            };
            WriteFile(populateList);
            ReadFile();
        }

        public int[] getAllIDs() {
            return itemList.Keys.ToArray();
        }

        public string getName(int ID) {
            return itemList[ID].name;
        }

        public int getCount(int ID) {
            return itemList[ID].count;
        }

        public int getPrice(int ID) {
            return itemList[ID].price;
        }

    }
    
}
