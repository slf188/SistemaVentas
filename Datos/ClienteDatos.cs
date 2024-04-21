﻿using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteDatos : IDatos<Cliente>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-21
        // PRÁCTICA No. #4


        serviciosEntities contexto;
        public ClienteDatos() { 
            contexto = new serviciosEntities();
        }
        public bool Actualizar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Cliente item)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Cliente item)
        {
            try
            {
                contexto.Cliente.Add(item);
                contexto.SaveChanges();
                return true;
            }catch (Exception)
            {
                return false;
            }
            
        }

        public List<Cliente> Listar()
        {
            return contexto.Cliente.ToList();
        }
    }
}
