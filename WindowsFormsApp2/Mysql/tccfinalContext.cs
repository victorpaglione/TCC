using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WindowsFormsApp2.Mysql
{
    public partial class tccfinalContext : DbContext
    {
        public tccfinalContext()
        {
        }

        public tccfinalContext(DbContextOptions<tccfinalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avaliacao> Avaliacao { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<MetodoPag> MetodoPag { get; set; }
        public virtual DbSet<Orcamentos> Orcamentos { get; set; }
        public virtual DbSet<Servico> Servico { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TipoPessoa> TipoPessoa { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=;Database=tccfinal");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>(entity =>
            {
                entity.HasKey(e => e.CodAva);

                entity.ToTable("avaliacao");

                entity.Property(e => e.CodAva)
                    .HasColumnName("cod_ava")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Avaliacao1)
                    .IsRequired()
                    .HasColumnName("avaliacao")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CodCliente);

                entity.ToTable("cliente");

                entity.HasIndex(e => e.AvaliacaoCliente)
                    .HasName("fk_ava");

                entity.HasIndex(e => e.TipoPessoa)
                    .HasName("fk_pessoa");

                entity.HasIndex(e => e.Uf)
                    .HasName("fk_uf");

                entity.Property(e => e.CodCliente)
                    .HasColumnName("Cod_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvaliacaoCliente)
                    .HasColumnName("avaliacao_cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CepCliente)
                    .HasColumnName("cep_cliente")
                    .HasColumnType("int(8)");

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasColumnName("cidade")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.CpfCnpj)
                    .HasColumnName("cpf_cnpj")
                    .HasColumnType("int(14)");

                entity.Property(e => e.EmailCliete)
                    .IsRequired()
                    .HasColumnName("email_cliete")
                    .HasColumnType("varchar(40)");

                entity.Property(e => e.EnderecoCliente)
                    .IsRequired()
                    .HasColumnName("endereco_cliente")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NomeCliente)
                    .IsRequired()
                    .HasColumnName("nome_cliente")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OrcamentosFeitos)
                    .HasColumnName("orcamentos_feitos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TelCel)
                    .HasColumnName("tel_cel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TelFixo)
                    .HasColumnName("tel_fixo")
                    .HasColumnType("int(10)");

                entity.Property(e => e.TipoPessoa)
                    .HasColumnName("tipo_pessoa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uf)
                    .HasColumnName("UF")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.AvaliacaoClienteNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.AvaliacaoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ava");

                entity.HasOne(d => d.TipoPessoaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.TipoPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_pessoa");

                entity.HasOne(d => d.UfNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.Uf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_uf");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.CodEstao);

                entity.ToTable("estado");

                entity.Property(e => e.CodEstao)
                    .HasColumnName("cod_estao")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado1)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<MetodoPag>(entity =>
            {
                entity.HasKey(e => e.CodMetodo);

                entity.ToTable("metodo_pag");

                entity.Property(e => e.CodMetodo)
                    .HasColumnName("cod_metodo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MPag)
                    .IsRequired()
                    .HasColumnName("m_pag")
                    .HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Orcamentos>(entity =>
            {
                entity.HasKey(e => e.CodOrca);

                entity.ToTable("orcamentos");

                entity.HasIndex(e => e.Cliente)
                    .HasName("fk_cliente");

                entity.HasIndex(e => e.MetodoPag)
                    .HasName("fk_metodo_pag");

                entity.HasIndex(e => e.StatusOrca)
                    .HasName("fk_status");

                entity.Property(e => e.CodOrca)
                    .HasColumnName("cod_orca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnoId)
                    .HasColumnName("ano_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cliente)
                    .HasColumnName("cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataEntrega)
                    .HasColumnName("data_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.DataOrca)
                    .HasColumnName("data_orca")
                    .HasColumnType("date");

                entity.Property(e => e.DiaId)
                    .HasColumnName("dia_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MesId)
                    .HasColumnName("mes_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MetodoPag)
                    .HasColumnName("metodo_pag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusOrca)
                    .HasColumnName("status_orca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValorOrca).HasColumnName("valor_orca");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Orcamentos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cliente");

                entity.HasOne(d => d.MetodoPagNavigation)
                    .WithMany(p => p.Orcamentos)
                    .HasForeignKey(d => d.MetodoPag)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_metodo_pag");

                entity.HasOne(d => d.StatusOrcaNavigation)
                    .WithMany(p => p.Orcamentos)
                    .HasForeignKey(d => d.StatusOrca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_status");
            });

            modelBuilder.Entity<Servico>(entity =>
            {
                entity.HasKey(e => new { e.CodServico, e.CodOrca });

                entity.ToTable("servico");

                entity.Property(e => e.CodServico)
                    .HasColumnName("cod_servico")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodOrca)
                    .HasColumnName("cod_orca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescServ)
                    .IsRequired()
                    .HasColumnName("desc_serv")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.ValorServiço).HasColumnName("valor_serviço");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.CodStatus);

                entity.ToTable("status");

                entity.Property(e => e.CodStatus)
                    .HasColumnName("cod_status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<TipoPessoa>(entity =>
            {
                entity.HasKey(e => e.CodTipoPessoa);

                entity.ToTable("tipo_pessoa");

                entity.Property(e => e.CodTipoPessoa)
                    .HasColumnName("cod_tipo_pessoa")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoPessoa1)
                    .IsRequired()
                    .HasColumnName("tipo_pessoa")
                    .HasColumnType("varchar(15)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.CodUser);

                entity.ToTable("user");

                entity.Property(e => e.CodUser)
                    .HasColumnName("cod_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnType("varchar(16)");
            });
        }
    }
}
