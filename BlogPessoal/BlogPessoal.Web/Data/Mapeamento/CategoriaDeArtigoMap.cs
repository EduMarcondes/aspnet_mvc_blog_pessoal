using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class CategoriaDeArtigoMap : EntityTypeConfiguration<CategoriaDeArtigoMap>
    {
        public CategoriaDeArtigoMap()
        {
            ToTable("categoria_artigo", "dbo");

            //HasKey(t => t.Id);

            //Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColunmName("Nome");


        }
    }
}