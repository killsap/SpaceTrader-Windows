/*******************************************************************************
 *
 * Space Trader for Windows File Converter 2.0.0
 *
 * Copyright (C) 2004 Jay French, All Rights Reserved
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
 ******************************************************************************/
using System;
using System.Collections;

namespace Fryz.Apps.SpaceTrader
{
	[Serializable()]      
	public class ShipSpec: STSerializableObject
	{
		#region Member Declarations

		private ShipType	_type					= ShipType.Flea;
		private Size			_size					= Size.Tiny;
		private int				_cargoBays		= 0;
		private int				_weaponSlots	= 0;
		private int				_shieldSlots	= 0;
		private int				_gadgetSlots	= 0;
		private int				_crewQuarters	= 0;
		private int				_fuelTanks		= 0;
		private int				_fuelCost			= 0;
		private int				_hullStrength	= 0;
		private int				_repairCost		= 0;
		private int				_price				= 0;
		private int				_occurance		= 0;
		private int				_police				= 0;
		private int				_pirates			= 0;
		private int				_traders			= 0;
		private TechLevel	_minTech			= TechLevel.HiTech;
		private bool			_hullUpgraded	= false;

		#endregion

		#region Methods

		public override Hashtable Serialize()
		{
			Hashtable	hash	= base.Serialize();

			hash.Add("_type",					(int)_type);
			hash.Add("_size",					(int)_size);
			hash.Add("_cargoBays",		_cargoBays);
			hash.Add("_weaponSlots",	_weaponSlots);
			hash.Add("_shieldSlots",	_shieldSlots);
			hash.Add("_gadgetSlots",	_gadgetSlots);
			hash.Add("_crewQuarters",	_crewQuarters);
			hash.Add("_fuelTanks",		_fuelTanks);
			hash.Add("_fuelCost",			_fuelCost);
			hash.Add("_hullStrength",	_hullStrength);
			hash.Add("_repairCost",		_repairCost);
			hash.Add("_price",				_price);
			hash.Add("_occurance",		_occurance);
			hash.Add("_police",				_police);
			hash.Add("_pirates",			_pirates);
			hash.Add("_traders",			_traders);
			hash.Add("_minTech",			(int)_minTech);
			hash.Add("_hullUpgraded",	_hullUpgraded);

			return hash;
		}

		#endregion
	}
}
