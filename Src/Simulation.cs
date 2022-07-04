using CellularAutomata.Cells;
using CellularAutomata.Events;
using CellularAutomata.Example;
using Microsoft.Xna.Framework;
using Simulation.Cells;

namespace Simulation;

public class Simulation : CellularAutomata.CellularAutomata
{
    private CellHandler _cellHandler = null!;
    
    public Simulation() : base(256, 256, 1) 
    {
    }

    protected override void Initialize()
    {
        base.Initialize();
        CellEvents.RegisterCellTypes += RegisterCellTypes;
        _cellHandler = new CellHandler(GraphicsDevice);
    }

    protected override void Draw(GameTime gameTime)
    {
        base.Draw(gameTime);
        _cellHandler.DrawHud(SpriteBatch);
    }

    private static void RegisterCellTypes(List<Cell> registry)
    {
        registry.Add(new SandCell());
        registry.Add(new WaterCell());
    }
}