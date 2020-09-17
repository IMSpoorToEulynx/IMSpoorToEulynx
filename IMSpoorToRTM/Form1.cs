﻿using Models.File;
using Models.Service;
using Models.TopoModels.Eulynx;
using Models.TopoModels.IMSpoor;
using Models.Translation;
using Services.Service;
using System;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        private ITranslationService<IMSpoor, Eulynx> imspoorToEulynxTranslationService = new IMSpoorToEulynxTranslationService();
        private IReadFileService<IMSpoor> imSpoorFileReadService = new ReadIMSpoorFileService();
        private IXDocSerializer<Eulynx> eulynxSerializer = new XDocSerializeService();

        public Form1()
        {
            InitializeComponent();

            //textBox_IMSpoorXML.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            textBox_IMSpoorXML.Text = @"C:\Users\jurje\OneDrive\Documenten\ProRail EULYNX IMSPOOR Collections\IMSpoor-1.3.0_Examples\IMSpoor-1.3.0-actual.xml";
        }

        private void button_chooseIMSpoorXML_Click(object sender, EventArgs e)
        {
            openFileDialog_IMSpoorXML.InitialDirectory = textBox_IMSpoorXML.Text;
            
            if(openFileDialog_IMSpoorXML.ShowDialog() == DialogResult.OK)
            {
                textBox_IMSpoorXML.Text = openFileDialog_IMSpoorXML.FileName;
            }
        }

        private void button_startConversion_Click(object sender, EventArgs e)
        {
            String filePath = textBox_IMSpoorXML.Text;

            IMSpoor imSpoor = imSpoorFileReadService.Read(filePath);
            Eulynx eulynx = imspoorToEulynxTranslationService.Translate(imSpoor);

            XDocument eulynxDoc = eulynxSerializer.Serialize(eulynx);

            saveFileDialog_EulynxXMLOutput.InitialDirectory = @"C:\Users\jurje\OneDrive\Documenten\Eulynxgens\EULYNX-from-IMSpoor.xml";
            if (saveFileDialog_EulynxXMLOutput.ShowDialog() == DialogResult.OK)
            {
                eulynxDoc.Save(saveFileDialog_EulynxXMLOutput.FileName);
            }

            TopologyView topologyView = new TopologyView(eulynx);
            topologyView.Show();
        }
    }
}
