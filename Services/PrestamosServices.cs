using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System.Linq.Expressions;
using SebastianSuarez_AP1_P1.DAL;
using SebastianSuarez_AP1_P1.Models;

namespace SebastianSuarez_AP1_P1.Services;

public class PrestamosServices
{
    private readonly Contexto _contexto;

    public PrestamosServices(Contexto context)
    {
        _contexto = context;

    }

    public async Task<bool> Existe(int id)
    {
        return await _contexto.Prestamo.AnyAsync(p => p.PrestamoId == id);
    }

    public async Task<bool> Insertar(Prestamos prestamo)
    {
        _contexto.Prestamo.Add(prestamo);
        int insertado = await _contexto.SaveChangesAsync();
        _contexto.Entry(prestamo).State = EntityState.Detached;
        return insertado > 0;
    }
    public async Task<bool> Modificar(Prestamos prestamo)
    {
        _contexto.Update(prestamo);
        int modificado = await _contexto.SaveChangesAsync();
        _contexto.Entry(prestamo).State = EntityState.Detached;
        return modificado > 0;
    }

    public async Task<bool> Guardar(Prestamos prestamo)
    {
        if (!await Existe(prestamo.PrestamoId))
            return await Insertar(prestamo);
        else
            return await Modificar(prestamo);
    }

    public async Task<bool> Eliminar(int id)
    {
        var registro = await _contexto.Prestamo.Where(p => p.PrestamoId == id)
          .ExecuteDeleteAsync();
        return registro > 0;
    }

    public async Task<Prestamos?> Buscar(int id)
    {
        return await _contexto.Prestamo.AsNoTracking().FirstOrDefaultAsync(p => p.PrestamoId == id);
    }

    public async Task<List<Prestamos>> Listar(Expression<Func<Prestamos, bool>> criterio)
    {
        return await _contexto.Prestamo.AsNoTracking().Where(criterio).ToListAsync();
    }

}




