﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaPrototipo.Mantenimiento
{//carlos enrique 29 de febrero
    public partial class frMantenimientoCurso : Form
    {
        public frMantenimientoCurso()
        {
            InitializeComponent();
            this.navegador1.config("cursos", this, "");
            this.navegador1._initSeguridad();
        }

        private void frMantenimientoCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
