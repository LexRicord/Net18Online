﻿using MazeCore.Models;
using MazeCore.Models.Cells.Character;
using System.Text;

namespace MazeCore.Models.Cells
{
    public class Dungeon : BaseCell
    {
        public Dungeon(int x, int y, Maze maze) : base(x, y, maze)
        {

        }

        public override char Symbol => 'v';

        public override void InteractWithCell(BaseCharacter character)
        {
            AddEventInfo("Step Step Step....");
        }

        public override bool TryStep(BaseCharacter character)
        {
            return true;
        }
    }
}
