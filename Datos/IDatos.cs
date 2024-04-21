using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDatos<T>
    {
        // NOMBRE APELLIDOS: Felipe Vallejo
        // SI – INTEGRACIÓN DE SISTEMAS 
        // FECHA: 2024-04-21
        // PRÁCTICA No. #4

        List<T> Listar();
        bool Insertar(T item);
        bool Actualizar(T item);
        bool Eliminar(T item);
    }
}
