using System.Collections;
using CellularAutomata.Cells;
using CellularAutomata.World;
using Microsoft.Xna.Framework;

namespace Simulation.Cells;

public class WaterCell : Cell
{
    public override IEnumerator Update(GameWorld world, int thisX, int thisY)
    {
        yield return base.Update(world, thisX, thisY);
        if (world.TryMove(this, thisX, thisY, thisX, thisY + 1)) yield break;
        if (world.TryMove(this, thisX, thisY, thisX - 1, thisY + 1)) yield break;
        if (world.TryMove(this, thisX, thisY, thisX + 1, thisY + 1)) yield break;
        if (world.TryMove(this, thisX, thisY, thisX - 1, thisY)) yield break;
        world.TryMove(this, thisX, thisY, thisX + 1, thisY);
    }

    public override Color CellColor()
    {
        return Color.Aqua;
    }

    public override Cell Clone()
    {
        return new WaterCell();
    }
}