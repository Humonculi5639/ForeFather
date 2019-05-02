﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForeFather
{
    class Door
    {
        private Texture2D sprite;
        private Rectangle position;

        public Door()
        {

        }

        public Door(Texture2D s)
        {
            sprite = s;
        }

        public Door(Texture2D s, Rectangle pos)
        {
            sprite = s;
            position = pos;
        }

        public Rectangle getPos()
        {
            return position;
        }

        public bool Intersects(Rectangle r)
        {
            if (r.Intersects(position) && (r.Y >= position.Y) && (r.X >= position.X && r.X + r.Width <= position.X + position.Width))
                return true;
            return false;
        }

        public void Draw(SpriteBatch spriteBatch, Player p)
        {
            if(p.Intersects(position))
                spriteBatch.Draw(sprite, position, Color.Beige);
            else
                spriteBatch.Draw(sprite, position, Color.Black);

        }

    }
}
