using APS01_Dominio.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace APS01_Dominio.DAOs
{
    public class ProdutoDAO : BaseDAO<Produto>, IDAO<Produto>
    {
        protected override string GetSqlDelete() =>
            "DELETE FROM TBPROFESSORES WHERE PROF_IN_MATRICULA=@PROF_IN_MATRICULA";

        protected override string GetSqlInsert() =>
            "INSERT INTO TBPROFESSORES (PROF_IN_MATRICULA, PROF_TX_NOME) VALUES (@PROF_IN_MATRICULA, @PROF_TX_NOME)";

        protected override string GetSqlSelect() =>
            "SELECT * FROM TBPROFESSORES ORDER BY PROF_TX_NOME";

        protected override string GetSqlSelectId() =>
            "SELECT * FROM TBPROFESSORES WHERE PROF_IN_MATRICULA=@PROF_IN_MATRICULA";

        protected override string GetSqlUpdate() =>
            "UPDATE TBPROFESSORES SET PROF_TX_NOME=@PROF_TX_NOME WHERE PROF_IN_MATRICULA=@PROF_IN_MATRICULA";

        protected override void AdicionarParametros(SqlCommand cmd, Produto obj)
        {
            cmd.Parameters.AddWithValue("@PROF_TX_NOME", obj.Descricao);
        }

        protected override Produto GetObjeto(DataRow reg)
        {
            var obj = new Produto();

            obj.Codigo = Convert.ToInt32(reg["PROF_IN_MATRICULA"]);
            obj.Descricao = reg["PROF_TX_NOME"].ToString();

            return obj;
        }
    }
}
