using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private KeyboardService keyboardService;
        private Point direction1 = new Point(Constants.CELL_SIZE, 0);
        private Point direction2 = new Point(Constants.CELL_SIZE, 0);

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Player 1 Controls

            // left
            if (keyboardService.IsKeyDown("a"))
            {
                direction1 = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (keyboardService.IsKeyDown("d"))
            {
                direction1 = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (keyboardService.IsKeyDown("w"))
            {
                direction1 = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (keyboardService.IsKeyDown("s"))
            {
                direction1 = new Point(0, Constants.CELL_SIZE);
            }

            Cycle cycle1 = (Cycle)cast.GetFirstActor("cycle1");
            cycle1.TurnCycle(direction1);
            
            // Player 2 controls
            
            // left
            if (keyboardService.IsKeyDown("left"))
            {
                direction2 = new Point(-Constants.CELL_SIZE, 0);
            }

            // right
            if (keyboardService.IsKeyDown("right"))
            {
                direction2 = new Point(Constants.CELL_SIZE, 0);
            }

            // up
            if (keyboardService.IsKeyDown("up"))
            {
                direction2 = new Point(0, -Constants.CELL_SIZE);
            }

            // down
            if (keyboardService.IsKeyDown("down"))
            {
                direction2 = new Point(0, Constants.CELL_SIZE);
            }

            Cycle cycle2 = (Cycle)cast.GetFirstActor("cycle2");
            cycle2.TurnCycle(direction2);

        }
    }
}