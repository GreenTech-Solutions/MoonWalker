﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonWalker
{
    public class Data
    {
        /// <summary>
        /// Координаты лунохода
        /// </summary>
        public Coord XY;

        /// <summary>
        /// Карта луны(в пределах видимости)
        /// </summary>
        public Obstacle[,] map = new Obstacle[15,15];

        /// <summary>
        /// Направление движения
        /// </summary>
        public Direction d;
    }

    /// <summary>
    /// Всевозможные варианты объектов на карте
    /// </summary>
    public enum Obstacle
    {
        Empty,
        Rock,
        Hole,
        Mooners
    }

    /// <summary>
    /// Направление движения лунохода
    /// </summary>
    public enum Direction
    {
        Up = 0,
        Left = 1,
        Right = 2,
        Down = 3,
        Unknown = 4
    }

    /// <summary>
    /// Действие лунохода (Вперёд, назад, поворот направо, поворот налево)
    /// </summary>
    public enum Action
    {
        B,
        F,
        L,
        R
    }
}
