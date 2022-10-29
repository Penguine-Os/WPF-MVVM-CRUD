using Microsoft.EntityFrameworkCore;
using models;

namespace dal;

public static class DatabaseOperations
{

    public static List<PolitiekePartij> HaalPartijenOp()
    {
        using (PolitiekDbContext ctx = new PolitiekDbContext())
        {

            return ctx.PolitiekePartijen
                .Include(x => x.PolitiekePartijNiveaus)
                .ThenInclude(y => y.Niveau).ToList();
        }
    }
    public static List<Niveau> HaalNiveausOp()
    {
        using (PolitiekDbContext ctx = new PolitiekDbContext())
        {
            //return ctx.Niveaus.ToList();

            return default;
        }
    }

    public static List<PolitiekePartijNiveau> HaalPolitiekePartijNiveausOp(int politiekePartijID)
    {
        using (PolitiekDbContext ctx = new PolitiekDbContext())
        {
            //return ctx.PolitiekePartijNiveaus
            //    .Include(xx => xx.Niveau)
            //    .Where(x => x.PolitiekePartijID == politiekePartijID)
            //    .ToList();

            return default;
        }
    }

    public static List<Politicus> HaalPoliticiOp(int PolitiekePartijID)
    {
        using (PolitiekDbContext ctx = new PolitiekDbContext())
        {
            List<Politicus> politici = ctx.Politici
                .Include(x => x.PolitiekePartijNiveau)
                .Include(xx => xx.PolitiekePartijNiveau).ThenInclude(yy => yy.PolitiekePartij)
                .Include(xy => xy.PolitiekePartijNiveau).ThenInclude(zz => zz.Niveau)
                .Where(y => y.PolitiekePartijNiveau.PolitiekePartijID == PolitiekePartijID)
                .ToList();
            return politici;
        }
    }

    public static int BewaarPoliticus(Politicus politicus)
    {
        using (PolitiekDbContext ctx = new PolitiekDbContext())
        {

            //ctx.Politici.Update(politicus);
            //ctx.PolitiekePartijNiveaus.Update(politicus.PolitiekePartijNiveau);

            ctx.Entry(politicus).State = EntityState.Modified;
            ctx.Entry(politicus.PolitiekePartijNiveau).State = EntityState.Modified;
            return ctx.SaveChanges();
        }
    }
}