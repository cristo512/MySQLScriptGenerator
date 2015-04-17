using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MySQLScriptGenerator
{
    public enum CreateTableError
    {
        NoError,
        NoDatabase,
        StringIsEmpty,
        TableExsists
    };

    public class ScriptWriter
    {
        public ScriptWriter()
        {
            databaseFile = File.CreateText("Baza danych.txt");
            databases = new List<Database>();
        }


        public bool canCreateTable(string name, out CreateTableError reason)
        {
            reason = CreateTableError.NoError;
            if (usingDatabase == 0)
                reason = CreateTableError.NoDatabase;

            else if (string.IsNullOrEmpty(name))
                reason = CreateTableError.StringIsEmpty;

            else if (isTableInDatabase(name, databases.ElementAt(usingDatabase - 1)))
                reason = CreateTableError.TableExsists;

            
            return reason == CreateTableError.NoError;
        }

        private bool isTableInDatabase(string name, Database database)
        {
            for (int i = 0; i < database.table.Count(); i++)
            {
                if (database.table.ElementAt(i).name == name)
                    return true;
            }
            return false;
        }
        private bool isCorrectTable(string name, Database database, List<string> value)
        {
            for (int i = 0; i < database.table.Count(); i++)
            {
                if (database.table.ElementAt(i).name == name)
                {
                    if (value.Count() == database.table.ElementAt(i).valuesAmount)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
        private bool isDatabase(string name)
        {

            for (int i = 0; i < databases.Count(); i++)
            {
                if (databases.ElementAt(i).name == name)
                    return true;
            }
            return false;

        }

        public bool setUsingDatabase(string name)
        {
            databaseFile.Write("use " + name + ";\r\n\r\n");
            databaseFile.Flush();
            for (int i = 0; i < databases.Count(); i++)
            {
                if (databases.ElementAt(i).name == name)
                {
                    usingDatabase = i + 1;
                    return true;
                }
            }
            return false;
        }

	    public bool createDatabase(string name)
        {
            if(!isDatabase(name))
            {
                databaseFile.Write("create database " + name + ";\r\n\r\n");

                databases.Add(new Database(name));

                databaseFile.Flush();
                return true;
            }
            return false;
        }

        public void createTable(string name, List<string> value, List<string> type)
        {
            databaseFile.Write("create table " + name + "\r\n(\r\n");
            for (int i = 0; i < value.Count(); i++)
            {
                databaseFile.Write(value.ElementAt(i) + " " + type.ElementAt(i));
                databaseFile.Write(i + 1 == value.Count() ? "\r\n);\r\n\r\n" : ", \r\n");
            }

            databaseFile.Flush();
            databases.ElementAt(usingDatabase - 1).table.Add(new Table(name, value.Count()));

        }
        public int addRecord(string tableName, List<string> value)
        {
            if (usingDatabase == 0)
                return 1;

            if (!isCorrectTable(tableName, databases.ElementAt(usingDatabase - 1), value))
                return 2;

            databaseFile.Write("insert into " + tableName + " values (");
            for (int i = 0; i < value.Count(); i++)
            {
                databaseFile.Write(value.ElementAt(i));
                databaseFile.Write(i + 1 == value.Count() ? ");\r\n\r\n" : ", ");
            }

            databaseFile.Flush();

            return 0;

        }
        
	    StreamWriter databaseFile;
        List<Database> databases;
        public int usingDatabase = 0;
    }
}

