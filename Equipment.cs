/*******************************************************************************
 *
 * Space Trader for Windows 1.3.0
 *
 * Copyright (C) 2004 Jay French, All Rights Reserved
 *
 * Original coding by Pieter Spronck, Sam Anderson, Samuel Goldstein, Matt Lee
 *
 * This program is free software; you can redistribute it and/or modify it
 * under the terms of the GNU General Public License as published by the Free
 * Software Foundation; either version 2 of the License, or (at your option) any
 * later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
 *
 * If you'd like a copy of the GNU General Public License, go to
 * http://www.gnu.org/copyleft/gpl.html.
 * 
 * You can contact the author at spacetrader@frenchfryz.com
 *
 ******************************************************************************/
using System;

namespace Fryz.Apps.SpaceTrader
{
	[Serializable()]      
	public abstract class Equipment
	{
		#region Member Declarations

		protected EquipmentType	_equipType;
		protected int						_price;
		protected TechLevel			_minTech;
		protected int						_chance;

		#endregion

		#region Methods

		public Equipment(EquipmentType type, int price, TechLevel minTechLevel, int chance)
		{
			_equipType	= type;
			_price			= price;
			_minTech		= minTechLevel;
			_chance			= chance;
		}

		public abstract Equipment Clone();

		public abstract bool TypeEquals(object type);

		#endregion

		#region Properties

		public virtual string Name
		{
			get
			{
				return "";
			}
		}

		public EquipmentType EquipmentType
		{
			get
			{
				return _equipType;
			}
		}

		public int Price
		{
			get
			{
				Commander	cmdr	= Game.CurrentGame.Commander;
				int				price	= 0;

				if (cmdr != null && cmdr.CurrentSystem.TechLevel >= MinimumTechLevel)
					price	= (_price * (100 - cmdr.Ship.Trader)) / 100;

				return price;
			}
		}

		public TechLevel MinimumTechLevel
		{
			get
			{
				return _minTech;
			}
		}

		public int Chance
		{
			get
			{
				return _chance;
			}
		}

		public int SellPrice
		{
			get
			{
				return _price * 3 / 4;
			}
		}

		public int TransferPrice
		{
			get
			{
				// The cost to transfer is 10% of the item worth. This is changed
				// from actually PAYING the buyer about 8% to transfer items. - JAF
				return SellPrice * 110 / 90;
			}
		}

		#endregion
	}
}