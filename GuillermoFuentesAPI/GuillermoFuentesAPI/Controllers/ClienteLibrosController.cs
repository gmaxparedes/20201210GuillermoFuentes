using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuillermoFuentesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Volo.Abp.Data;

namespace GuillermoFuentesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteLibrosController : ControllerBase
    {
        private readonly ConnectionStrings connectionStrings;
        public ClienteLibrosController(IOptions<ConnectionStrings> connectionStrings)
        {
            this.connectionStrings = connectionStrings.Value;
        }

        [HttpPost]
        public IActionResult PrestarLibro([FromBody] ClienteLibros clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                try
                {
                    using (SqlCommand cm = new SqlCommand("PrestarLibro", sqlcon))
                    {
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@IdCliente", clientes.IdCliente));
                        cm.Parameters.Add(new SqlParameter("@IdLibro", clientes.IdLibro));

                        

                        cm.Connection.Open();
                        cm.ExecuteNonQuery();

                        cm.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

            }
            return Ok();
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public List<ClienteLibros> Get(int id)
        {
            List<ClienteLibros> clienteLibros = new List<ClienteLibros>();
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
                {
                    using (SqlCommand cm = new SqlCommand("select * from  TblClienteLibros where IdCliente=" + id))
                    {
                        using (SqlDataAdapter dt = new SqlDataAdapter())
                        {
                            cm.Connection = sqlcon;
                            sqlcon.Open();
                            dt.SelectCommand = cm;

                            SqlDataReader dr = cm.ExecuteReader();

                            while (dr.Read())
                            {
                                ClienteLibros cl = new ClienteLibros();
                                cl.Id = Convert.ToInt32(dr["Id"]);
                                cl.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                                cl.IdLibro = Convert.ToInt32(dr["IdLibro"]);
                                cl.FechaEntrega = Convert.ToDateTime(dr["FechaEntrega"]);                                
                                if (!String.IsNullOrEmpty(dr["FechaRegresa"].ToString()))
                                    cl.FechaRegreso = Convert.ToDateTime(dr["FechaRegresa"]);
                                clienteLibros.Add(cl);


                            }
                            sqlcon.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            
            return clienteLibros;
        }


        [HttpPut]
        public IActionResult Put([FromBody] ClienteLibros clienteLibros)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                try
                {
                    using (SqlCommand cm = new SqlCommand("RegresarLibro", sqlcon))
                    {
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@Id", clienteLibros.Id));                        

                        cm.Connection.Open();
                        cm.ExecuteNonQuery();

                        cm.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

            }
            return Ok();
        }


    }
}
