using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MontagemCurriculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Mapeamento
{
    public class InformacaoLoginMap : IEntityTypeConfiguration<InformacaoLogin>
    {
        public void Configure(EntityTypeBuilder<InformacaoLogin> builder)
        {
            builder.HasKey(i => i.InformacoLoginId);

            builder.Property(i => i.EnderecoIP).IsRequired();
            builder.Property(i => i.Horario).IsRequired();
            builder.Property(i => i.Data).IsRequired();

            builder.HasOne(i => i.Usuario).WithMany(i => i.InformacoesLogin).HasForeignKey(i => i.UsuarioId);

            builder.ToTable("InformacoesLogin");

        }
    }
}
