﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QueryDesk
{
    public enum AppDBServerType { Void, MySQL };

    /// <summary>
    /// Query class providing properties to bind from code and from WPF, reading and writing to similar properties of a non-prefined object, or a DataRowView
    /// </summary>
    public class AppDBQueryLink : INotifyPropertyChanged
    {
        protected object data = null;
        public event PropertyChangedEventHandler PropertyChanged;

        public AppDBQueryLink()
        {

        }

        public AppDBQueryLink(object source)
        {
            setSource(source);
        }

        public void setSource(object source)
        {
            data = source;

            NotifyPropertyChanged("name");
            NotifyPropertyChanged("sqltext");
            //NotifyPropertyChanged("name");
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public long id
        {
            get
            {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    // todo: panic, why doesn't this have a cast to long available?
                    return (int)row["id"];
                }
                else
                {
                    return (long)(data.GetType().GetProperty("id").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                data.GetType().GetProperty("id").SetValue(data, value);
                NotifyPropertyChanged("id");
            }
        }

        public long connection_id
        {
            get
            {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    // todo: panic, why doesn't this have a cast to long available?
                    return (long)row["connection_id"];
                }
                else
                {
                    return (long)(data.GetType().GetProperty("connection_id").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                data.GetType().GetProperty("connection_id").SetValue(data, value);
                NotifyPropertyChanged("connection_id");
            }
        }
        public string name
        {
            get
            {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["name"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("name").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["name"] = value;
                }
                else
                {
                    data.GetType().GetProperty("name").SetValue(data, value);
                }

                NotifyPropertyChanged("name");
            }
        }
        public string sqltext
        {
            get
            {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["sqltext"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("sqltext").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["sqltext"] = value;
                }
                else
                {
                    data.GetType().GetProperty("sqltext").SetValue(data, value);
                }

                NotifyPropertyChanged("sqltext");
            }
        }
    }

    /// <summary>
    /// Server Class providing properties to bind to from code and from WPF, reading and writing to similar properties of a non-prefined object, or a DataRowView
    /// </summary>
    public class AppDBServerLink: INotifyPropertyChanged
    {
        protected object data = null;
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public long id
        {
            get
            {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    // todo: panic, why doesn't this have a cast to long available?
                    return (int)row["id"];
                }
                else
                {
                    return (long)(data.GetType().GetProperty("id").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["id"] = value;
                }
                else
                {
                    data.GetType().GetProperty("id").SetValue(data, value);
                }

                NotifyPropertyChanged("id");
            }
        }

        public string name
        {
            get {
                Debug.Assert(data != null);
                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["name"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("name").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["name"] = value;
                }
                else
                {
                    data.GetType().GetProperty("name").SetValue(data, value);
                }

                NotifyPropertyChanged("name");
            }
        }

        public string host
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["host"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("host").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["host"] = value;
                }
                else
                {
                    data.GetType().GetProperty("host").SetValue(data, value);
                }

                NotifyPropertyChanged("host");
            }
        }

        public int port
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (int)row["port"];
                }
                else
                {
                    return (int)(data.GetType().GetProperty("port").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["port"] = value;
                }
                else
                {
                    data.GetType().GetProperty("port").SetValue(data, value);
                }

                NotifyPropertyChanged("port");
            }
        }

        public string username
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["username"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("username").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["username"] = value;
                }
                else
                {
                    data.GetType().GetProperty("username").SetValue(data, value);
                }

                NotifyPropertyChanged("username");
            }
        }

        public string password
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["password"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("password").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["password"] = value;
                }
                else
                {
                    data.GetType().GetProperty("password").SetValue(data, value);
                }

                NotifyPropertyChanged("password");
            }
        }

        public string databasename
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["databasename"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("databasename").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["databasename"] = value;
                }
                else
                {
                    data.GetType().GetProperty("databasename").SetValue(data, value);
                }

                NotifyPropertyChanged("databasename");
            }
        }
            
        public string extraparams
        {
            get
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    return (string)row["extraparams"];
                }
                else
                {
                    return (string)(data.GetType().GetProperty("extraparams").GetValue(data, null));
                }
            }
            set
            {
                Debug.Assert(data != null);

                if (data is DataRowView)
                {
                    DataRowView row = (DataRowView)data;
                    row["extraparams"] = value;
                }
                else
                {
                    data.GetType().GetProperty("extraparams").SetValue(data, value);
                }

                NotifyPropertyChanged("extraparams");
            }
        }

        public AppDBServerLink()
        {

        }

        public AppDBServerLink(object source)
        {
            SetSource(source);
        }

        public void SetSource(object source)
        {
            data = source;

            NotifyPropertyChanged("name");
            NotifyPropertyChanged("host");
            NotifyPropertyChanged("port");
            NotifyPropertyChanged("username");
            NotifyPropertyChanged("password");
            NotifyPropertyChanged("databasename");
            NotifyPropertyChanged("extraparams");
        }

        public string getConnectionString()
        {
            // todo: what if this isn't a mysqlconnection...

            // todo: port

            // todo: extraparams

            return
                "Server=" + host + ";" +
                "Database=" + databasename + ";" +
                "Uid=" + username + ";" +
                "Pwd=" + password + ";";
        }
    }

    public interface IAppDBEditableServers
    {
        long saveServer(AppDBServerLink server);
        void delServer(AppDBServerLink server);
    }

    public interface IAppDBEditableQueries
    {
        long saveQuery(AppDBQueryLink query);
        void delQuery(AppDBQueryLink query);
    }

    public interface IAppDBServersAndQueries
    {
        IEnumerable getServerListing();
        IEnumerable getQueriesListing(long server_id);
    }
}
