using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace ProxyChanger
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }
      RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
      TreeNode root = new TreeNode("Proxy", 0, 0);

      private void Form1_Load(object sender, EventArgs e)
      {
         GetProxy();
         ReadXml(Application.StartupPath + @"\Proxy.xml");
      }

      public void ReadXml(string xmlPath)
      {
         XmlDocument xml = new XmlDocument();
         xml.Load(xmlPath);
         XmlNodeList xnList = xml.SelectNodes("ROOT"); //접근할 노드

         foreach (XmlNode xn in xnList)
         {
            foreach(XmlNode xnn in xn)
            {
               string value = xnn.InnerText;
               treeView1.Nodes.Remove(root);
               root.Nodes.Add(value);
               treeView1.Nodes.Add(root);
               treeView1.ExpandAll();
            }
         }
      }

      public void WriteXml()
      {
         xmlClear(Application.StartupPath + @"\Proxy.xml");
         int cnt = 0;
         foreach(TreeNode data in root.Nodes )
         {
            xmlSave(Application.StartupPath + @"\Proxy.xml", @"PROXY"+cnt, data.Text.ToString(), true);
            cnt++;
         }   
      }

      public void xmlClear(string xmlPath)
      {
         try
         {
            string value = string.Empty;
            XmlDocument xdoc = new XmlDocument();

            FileInfo fi = new FileInfo(xmlPath);
            if (fi.Exists != false)
            {
               xdoc.Load(xmlPath);
            }
            XmlNode Root = xdoc.SelectSingleNode("ROOT");
            Root.RemoveAll();

            xdoc.Save(xmlPath);
            xdoc = null;
         }

         catch (Exception Ex)
         {
               MessageBox.Show(Ex.ToString());
         }
      }
      public string xmlLoad(string xmlPath, string node, string fineValue, bool showException = false)
      {
         string value = string.Empty;

         try
         {
            XmlDocument xml = new XmlDocument();
            xml.Load(xmlPath);
            XmlNodeList xnList = xml.SelectNodes(node); //접근할 노드

            foreach (XmlNode xn in xnList)
            {
               value = xn[fineValue].InnerText;
            }
         }
         catch (Exception Ex)
         {
            if (showException == true)
            {
               MessageBox.Show(Ex.ToString());
            }
         }

         return value;
      }


      public void xmlSave(string xmlPath, string Node, string Value, bool showException = false)
      {
         try
         {
            string value = string.Empty;
            XmlDocument xdoc = new XmlDocument();

            FileInfo fi = new FileInfo(xmlPath);
            if (fi.Exists != false)
            {
               xdoc.Load(xmlPath);
            }

            XmlNode Root = xdoc.SelectSingleNode("ROOT");
            XmlElement  xmlEle = xdoc.CreateElement(Node); // 추가할 Node 생성
            xmlEle.InnerText = Value;

            Root.AppendChild(xmlEle);


            // XML 파일 저장
            xdoc.Save(xmlPath);
            xdoc = null;
         }

         catch (Exception Ex)
         {
            if (showException == true)
            {
               MessageBox.Show(Ex.ToString());
            }
         }
      }



      public void GetProxy()
      {
         String Proxyuse = registry.GetValue("ProxyEnable").ToString();
         if(Proxyuse=="1")
         {
            cb_proxyUse.Checked = true;
            String ProxyAdd = registry.GetValue("ProxyServer").ToString();
            tb_mainProxy.Text = ProxyAdd;
            groupBox1.Enabled = true;
         }
         else
         {
            groupBox1.Enabled = false;
         }         
      }

      //public void changerProxy()
     // {
        // registry.SetValue("ProxyEnable", 1);
       //  registry.SetValue("ProxyServer", "127.0.0.1:8080");
    //  }

      private void btn_getProxy_Click(object sender, EventArgs e)
      {
         GetProxy();
      }

      private void btn_add_Click(object sender, EventArgs e)
      {
         if(Information.IsNothing(tb_proxyyAdd.Text) == false)
         {
            root.Nodes.Add(tb_proxyyAdd.Text);          
            treeView1.ExpandAll();
            WriteXml();
         }
         
      }

      private void btn_del_Click(object sender, EventArgs e)
      {
         DialogResult dr = 
         MessageBox.Show(treeView1.SelectedNode.ToString() + " Remove?", "Alram", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
         if (dr == DialogResult.OK)
         {
            treeView1.SelectedNode.Remove();
            WriteXml();
         }
         else
         {
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         WriteXml();
         MessageBox.Show("Save Complete!");
      }

      private void cb_proxyUse_CheckedChanged(object sender, EventArgs e)
      {
         if(cb_proxyUse.Checked==true)
         {
            registry.SetValue("ProxyEnable", 1);
            groupBox1.Enabled = true;
         }
         else if (cb_proxyUse.Checked == false)
         {
            registry.SetValue("ProxyEnable", 0);
            groupBox1.Enabled = false;
         }
      }

      private void btn_proxyUse_Click(object sender, EventArgs e)
      {
         if (Information.IsNothing(treeView1.SelectedNode.Text) == false && treeView1.SelectedNode.Text != "Proxy")
         {
            registry.SetValue("ProxyServer", treeView1.SelectedNode.Text);
            MessageBox.Show("프록시 변경 완료");
            GetProxy();
         }
         else
         {
            MessageBox.Show("프록시를 선택해 주세요!!");
         }
      }

      private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
      {
         if (Information.IsNothing(treeView1.SelectedNode.Text) == false && treeView1.SelectedNode.Text != "Proxy")
         {
            registry.SetValue("ProxyServer", treeView1.SelectedNode.Text);
            MessageBox.Show("프록시 변경 완료");
            GetProxy();
         }
         else
         {
            MessageBox.Show("프록시를 선택해 주세요!!");
         }
      }

      private void button1_Click_1(object sender, EventArgs e)
      {
         Process.Start(@"C:\Windows\System32\inetcpl.cpl");
      }



   }
}
