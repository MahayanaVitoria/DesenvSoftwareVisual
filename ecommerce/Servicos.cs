using System;
using System.Collections.Generic;
using System.IO;

namespace ecommerce
{
    class Usuario
    {

        static int UID = 0;

        int id;
        string username;
        string hash;

        public Usuario(string u, string p)
        {
            id = GetUID();
            // username = u;
            SetUsername (u);
            // hash = 
            ApplyHash(p);
        }

        static int GetUID(){
            UID++;
            return UID;
        }

        void ApplyHash(string password)
        {
            //TO DO aplicar hash
            hash = password;
        }

        public string GetUsername()
        {
            return username;
        }

        // public string GetHash()
        // {
        //     return hash;
        // }

        public void SetUsername(string u)
        {
            username = u;
        }

        public string GetHash()
        {
            return hash;
        }

        public string Serialize()
        {
            return id + ", " + username + ", " + hash;
        }

    }
    
    class UserBase
    {
        string filename;
        List<Usuario> usuarios;

        public UserBase(string f)
        {
            filename = f;
            usuarios = new List<Usuario>();
            LoadUsers();
        }

        void LoadUsers()
        {
            //TO DO carregar usuarios do arquivo
        }

        public void AddUser(Usuario u)
        {
            usuarios.Add(u);
        }

        public void Save()
        {
            string output = "";

            foreach (Usuario u in usuarios)
            {
                output += u.Serialize() + "\n";
            }

            File.WriteAllText(filename, output);
        }

    }
}