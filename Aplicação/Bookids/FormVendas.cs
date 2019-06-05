﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class FormVendas : Form
    {
        private ModelBookidsContainer BookidsContainer;

        public FormVendas()
        {
            InitializeComponent();
            BookidsContainer = new ModelBookidsContainer();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            carregarComboTipo();
            carregarComboClientes();
            limparDadosVendas();
        }

        public void carregarComboClientes()
        {
            var listaClientes = from Clientes in BookidsContainer.ClientesSet
                                orderby Clientes.Nome
                                select Clientes;
            cbClientes.DataSource = listaClientes.ToList<Clientes>();
        }

        private void carregarDadosVendas(Clientes cliente)
        {
            var listaVendas = from Compras in BookidsContainer.ComprasSet
                              where Compras.IdCliente == cliente.IdPessoa
                              orderby Compras.Data
                              select Compras;
            comprasBindingSource.DataSource = listaVendas.ToList();
            tbNrCartao.Text = cliente.NrCartao;
            tbValorOferta.Text = Convert.ToString(cliente.ValorOferta);
        }

        private void carregarComboTipo()
        {
            var listaTipos = from TipoProduto in BookidsContainer.TipoProdutoSet
                             orderby TipoProduto.Tipo
                             select TipoProduto;
            cbTipoProduto.DataSource = listaTipos.ToList<TipoProduto>();
        }

        public void carregarListaProtudos()
        {
            var listaProdutos = from Produtos in BookidsContainer.ProdutosSet
                                orderby Produtos.Designacao
                                where Produtos.TipoProduto.CodTipoProduto == 
                            ((TipoProduto)cbTipoProduto.SelectedItem).CodTipoProduto
                                select Produtos;
            lbProdutos.DataSource = listaProdutos.ToList<Produtos>();
        }

        private void limparDadosVendas()
        {
            dgvVendas.ClearSelection();
            tbNrCartao.Clear();
            tbValorOferta.Clear();
            btRegistarVenda.Enabled = true;
            btGuardarVenda.Enabled = false;
            btEditarVenda.Enabled = false;
            btApagarVenda.Enabled = false;
            btCancelCleanVenda.Enabled = false;
            gbDetalhesVenda.Enabled = false;
        }

        private void btRegistarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes cliente = (Clientes)cbClientes.SelectedItem;
                dgvVendas.ClearSelection();
                btRegistarVenda.Enabled = false;
                btGuardarVenda.Enabled = true;
                btCancelCleanVenda.Enabled = true;
                gbDetalhesVenda.Enabled = true;
                //codigo teste para criar compra
                /*
                Compras compra = new Compras()
                {
                    Data = DateTime.Now,
                    IdCliente = cliente.IdPessoa,
                    UtilizouCartao = true
                };
                BookidsContainer.ComprasSet.Add(compra);
                BookidsContainer.SaveChanges();
                carregarDadosVendas(cliente);*/
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarDadosVendas((Clientes)cbClientes.SelectedItem);
        }

        private void cbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregarListaProtudos();
            lbProdutos.ClearSelected();
        }

        
    }
}
