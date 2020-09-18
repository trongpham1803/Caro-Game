﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SocketManager
    {
        #region Client
        Socket client;
       
        public bool ConnecServer()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), Port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                client.Connect(ipep);
                return true;
            }
            catch
            {
                return false;
            }
            //return false;
        }
        #endregion

        #region Server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), Port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(ipep);
            server.Listen(10);
            Thread acceptClient = new Thread(() =>
            {
                client = server.Accept();
            });
            acceptClient.IsBackground = true;
            acceptClient.Start();
        }
        #endregion

        #region Both
        public string IP = "127.0.0.1";
        public int Port = 9999;
        public const int Buffer = 1024;
        public bool isServer = true;

        public bool isConnect()
        {
            
            if (client == null || server == null || client.Connected && server.Connected )
                return true;
            return false;
        }
        public void Close()
        {
            client.Close();
            server.Close();
            isServer = false;
        }

        public bool Send(object data)
        {
            byte[] sendData = SerializeData(data);
            
            return SendData(client, sendData);  
        }

        public object Received()
        {
            byte[] receivedata = new byte[Buffer];
            bool isOK = ReceiveData(client, receivedata);

            return DeserializeData(receivedata);
        }
        private bool SendData(Socket Target, byte[] data)
        {
            if (Target == null)
                return false;
            return Target.Send(data) == 1 ? true : false;
        }

        private bool ReceiveData(Socket Target, byte[] data)
        {
            return Target.Receive(data) == 1 ? true : false;
        }
        public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }


        // Giải nén mảng byte[] thành 1 đối tượng object
        public object DeserializeData (byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }

        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string stringIP = "";
            foreach ( NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if(item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach(UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if(ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            stringIP = ip.Address.ToString();
                        }    
                    }    
                }    
            }
            return stringIP;
        }
        // Lấy địa chỉ IPv4 của người chơi


        #endregion
    }
}
