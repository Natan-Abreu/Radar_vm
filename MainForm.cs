/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 10/09/2019
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace radar_vm
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			/*Declaração de variáveis e coleta de dados inseridos pelo usuário.
			Nesse caso, precisamos realizar a conversão para float:
			Tipo da variável + nome da variável + conversão + ítem do design + propriedade à ser alterada.*/
			float p1 = float.Parse(textBox1.Text);
			float p2 = float.Parse(textBox2.Text);
			float time = float.Parse(textBox4.Text);
			
			//Realização do cálculo
			//A variável precisa ser do tipo float! Dentro do parênteses para priorização do cálculos
			float velo_m = (p2 - p1) / time;
			
			//Mostrando pro usuário
			/*Nesse caso, eu quero que a text box 3 tenha seu texto alterado para o resultado da variável
			e a seguir, deve ser convertido para string através do .ToString*/
			textBox3.Text = velo_m.ToString();
			
			//Modo de inserir a imagem
			/*pictureBox3.Image = Image.FromFile("80kmporhora.png");*/
			
			/*A partir daqui se inicia uma estrutura de decisão (IF ELSE)*/
			if (velo_m > 80) {
				pictureBox3.Image = Image.FromFile("HAMILTON.gif");
				textBox3.Text = "Acima do limite! SE CONTROLE, POR FAVOR!";
			} else {
				pictureBox3.Image = Image.FromFile("MESSI_JOINHA.gif");
				textBox3.Text = "Dentro do limite! Pode ir pro fut!";
			}
			
			/*OBSERVAÇÕES: quando estivermos alterando as características da imagem
			devemos colocar a opção zoom para que a imagem se adapte automaticamente
			ao tamanho do programa/form!!!*/
		}
		
	}
}
