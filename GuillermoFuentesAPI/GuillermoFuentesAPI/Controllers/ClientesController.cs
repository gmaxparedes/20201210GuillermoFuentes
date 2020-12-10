using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Volo.Abp.Data;
using GuillermoFuentesAPI.Models;
using Microsoft.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GuillermoFuentesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ConnectionStrings connectionStrings;
        public ClientesController(IOptions<ConnectionStrings> connectionStrings)
        {
            this.connectionStrings = connectionStrings.Value;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public List<Clientes> Get()
        {
            List<Clientes> ListClientes = new List<Clientes>();
            using(SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                using(SqlCommand cm = new SqlCommand("select * from  TblClientes"))
                {
                    using(SqlDataAdapter dt = new SqlDataAdapter())
                    {
                        cm.Connection = sqlcon;
                        sqlcon.Open();
                        dt.SelectCommand = cm;

                        SqlDataReader dr = cm.ExecuteReader();

                        while (dr.Read())
                        {
                            Clientes cliente = new Clientes();
                            cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                            cliente.NombreCliente = dr["NombreCliente"].ToString();
                            cliente.ApellidosCliente = dr["ApellidosCliente"].ToString();
                            cliente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"]);
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();

                            ListClientes.Add(cliente);
                        }
                        sqlcon.Close();

                    }
                }
            }
            return ListClientes;
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public Clientes Get(int id)
        {
            Clientes cliente = new Clientes();
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                using (SqlCommand cm = new SqlCommand("select * from  TblClientes where IdCliente="+id))
                {
                    using (SqlDataAdapter dt = new SqlDataAdapter())
                    {
                        cm.Connection = sqlcon;
                        sqlcon.Open();
                        dt.SelectCommand = cm;

                        SqlDataReader dr = cm.ExecuteReader();

                        while (dr.Read())
                        {
                            
                            cliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                            cliente.NombreCliente = dr["NombreCliente"].ToString();
                            cliente.ApellidosCliente = dr["ApellidosCliente"].ToString();
                            cliente.Nacimiento = Convert.ToDateTime(dr["Nacimiento"]);
                            cliente.Direccion = dr["Direccion"].ToString();
                            cliente.Telefono = dr["Telefono"].ToString();

                            
                        }
                        sqlcon.Close();
                    }
                }
            }
            return cliente;
        }

        // POST api/<ClientesController>        
        [HttpPost]
        public IActionResult Create([FromBody] Clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                try
                {
                    using (SqlCommand cm = new SqlCommand("CrearCliente", sqlcon))
                    {
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@IdCliente", clientes.IdCliente));
                        cm.Parameters.Add(new SqlParameter("@NombreCliente", clientes.NombreCliente));
                        cm.Parameters.Add(new SqlParameter("@ApellidosCliente", clientes.ApellidosCliente));
                        cm.Parameters.Add(new SqlParameter("@Nacimiento", clientes.Nacimiento));
                        cm.Parameters.Add(new SqlParameter("@Direccion", clientes.Direccion));
                        cm.Parameters.Add(new SqlParameter("@Telefono", clientes.Telefono));

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

        // PUT api/<ClientesController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Clientes clientes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not a valid model");
            }
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                try
                {
                    using (SqlCommand cm = new SqlCommand("EditarCliente", sqlcon))
                    {
                        cm.CommandType = System.Data.CommandType.StoredProcedure;
                        cm.Parameters.Add(new SqlParameter("@IdCliente", clientes.IdCliente));
                        cm.Parameters.Add(new SqlParameter("@NombreCliente", clientes.NombreCliente));
                        cm.Parameters.Add(new SqlParameter("@ApellidosCliente", clientes.ApellidosCliente));
                        cm.Parameters.Add(new SqlParameter("@Nacimiento", clientes.Nacimiento));
                        cm.Parameters.Add(new SqlParameter("@Direccion", clientes.Direccion));
                        cm.Parameters.Add(new SqlParameter("@Telefono", clientes.Telefono));

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


        // DELETE api/<ClientesController>/5
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {            
            using (SqlConnection sqlcon = new SqlConnection(connectionStrings.Values.FirstOrDefault().ToString()))
            {
                using (SqlCommand cm = new SqlCommand("delete from  TblClientes where IdCliente=" + Id, sqlcon))
                {
                    await sqlcon.OpenAsync();
                    await cm.ExecuteNonQueryAsync();
                    await sqlcon.CloseAsync();
                }
            }


            return NoContent();
        }
    }
}
