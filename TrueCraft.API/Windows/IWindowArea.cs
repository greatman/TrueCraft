﻿using System;

namespace TrueCraft.API.Windows
{
    public interface IWindowArea
    {
        event EventHandler<WindowChangeEventArgs> WindowChange;

        int StartIndex { get; set; }
        int Length { get; set; }
        ItemStack[] Items { get; set; }

        ItemStack this[int index] { get; set; }

        void CopyTo(IWindowArea area);
        int MoveOrMergeItem(int index, ItemStack item, IWindowArea from);
    }
}