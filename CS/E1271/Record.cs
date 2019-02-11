using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace E1271 {
    public class Record : INotifyPropertyChanged {
        public Record() {
            Details = new BindingList<Detail>();
        }
        int id;
        public int ID {
            get { return id; }
            set {
                if(id != value) {
                    id = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        int parentID;
        public int ParentID {
            get { return parentID; }
            set {
                if(parentID != value) {
                    parentID = value;
                    OnPropertyChanged("ParentID");
                }
            }
        }
        string text;
        public string Text {
            get { return text; }
            set {
                if(text != value) {
                    text = value;
                    OnPropertyChanged("Text");
                }
            }
        }
        string info;
        public string Info {
            get { return info; }
            set {
                if(info != value) {
                    info = value;
                    OnPropertyChanged("Info");
                }
            }
        }
        decimal? val;
        public decimal? Value {
            get { return val; }
            set {
                if(val != value) {
                    val = value;
                    OnPropertyChanged("Value");
                }
            }
        }
        DateTime dt;
        public DateTime Dt {
            get { return dt; }
            set {
                if(dt != value) {
                    dt = value;
                    OnPropertyChanged("Dt");
                }
            }
        }
        bool state;
        public bool State {
            get { return state; }
            set {
                if(state != value) {
                    state = value;
                    OnPropertyChanged("State");
                }
            }
        }
        Image image;
        public Image Image {
            get { return image; }
            set {
                if(image != value) {
                    image = value;
                    OnPropertyChanged("Image");
                }
            }
        }
        BindingList<Detail> details;
        public BindingList<Detail> Details {
            get { return details; }
            set {
                if(details != value) {
                    details = value;
                    OnPropertyChanged("Details");
                }
            }
        }
        public override string ToString() {
            return string.Format("ID = {0}", ID, Text);
        }
        Detail detail;
        public Detail Detail {
            get { return detail; }
            set {
                if(detail != value) {
                    detail = value;
                    OnPropertyChanged("Detail");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class Detail : INotifyPropertyChanged {
        public Detail() {
        }
        int id;
        public int ID {
            get { return id; }
            set {
                if(id != value) {
                    id = value;
                    OnPropertyChanged("ID");
                }
            }
        }
        string name;
        public string Name {
            get { return name; }
            set {
                if(name != value) {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        string info;
        public string Info {
            get { return info; }
            set {
                if(info != value) {
                    info = value;
                    OnPropertyChanged("Info");
                }
            }
        }
        bool state;
        public bool State {
            get { return state; }
            set {
                if(state != value) {
                    state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class DataHelper {
        public static BindingList<Record> GetData(int count) {
            BindingList<Record> records = new BindingList<Record>();
            for(int i = 0; i < count; i++) {
                records.Add(new Record() {
                    ParentID = i < 5 ? 1 : 2,
                    ID = i,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0} Line 1\r\n Line 2\r\n Line 3\r\n Line 4\r\n Line 5\r\n", i),
                    Dt = i % 2 == 0 ? DateTime.Now.AddDays(i) : DateTime.MinValue,
                    State = i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Value = (i * 0.00001M),
                    Detail = new Detail() { ID = i, Name = string.Format("Text {0}", i), State = i % 2 == 0 }
                });
            }
            return records;
        }
        public static BindingList<Record> GetData(int count, int detailCount) {
            BindingList<Record> records = new BindingList<Record>();
            for(int i = 0; i < count; i++) {
                records.Add(new Record() {
                    ParentID = i < 5 ? 1 : 2,
                    ID = i,
                    Text = string.Format("Text {0}", i),
                    Info = string.Format("Info {0} Line 1\r\n Line 2\r\n Line 3\r\n Line 4\r\n Line 5\r\n", i),
                    Dt = i % 2 == 0 ? DateTime.Now.AddDays(i) : DateTime.MinValue,
                    State = i % 2 == 0,
                    Image = SystemIcons.Information.ToBitmap(),
                    Value = (i * 0.00001M),
                    Detail = new Detail() { ID = i, Name = string.Format("Text {0}", i), State = i % 2 == 0 }
                });
                BindingList<Detail> details = new BindingList<Detail>();
                for(int j = 0; j < detailCount; j++) {
                    details.Add(new Detail() {
                        ID = j,
                        Name = string.Format("Text {0}", j),
                        Info = string.Format("Info {0}", j)
                    });
                }
                records[i].Details = details;
            }

            return records;
        }
    }
}
