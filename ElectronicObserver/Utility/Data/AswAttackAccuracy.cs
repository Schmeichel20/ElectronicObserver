﻿using System;
using System.Linq;
using ElectronicObserver.Data;

namespace ElectronicObserver.Utility.Data
{
	public static class AswAttackAccuracy
	{
		public static double GetAswAttackAccuracy(this IShipData ship, IFleetData fleet)
		{
			int baseAccuracy = fleet.BaseAccuracy();
			double shipAccuracy = ship.Accuracy();
			double equipAccuracy = ship.AllSlotInstance
				.Where(e => e != null)
				.Sum(e => e.MasterEquipment.Accuracy + e.AswAccuracy());

			return (baseAccuracy + shipAccuracy + equipAccuracy)
			       * ship.ConditionMod();
		}

		private static int BaseAccuracy(this IFleetData fleet) => 80;

		private static double DayAccuracyBonus(this IEquipmentData equip) => equip switch
		{
			{ } when equip.MasterEquipment.IsSonar => 1.3 * Math.Sqrt(equip.Level),

			_ => 0
		};

		private static double AswAccuracy(this IEquipmentData equip) => equip switch
		{
			{ } when equip.MasterEquipment.IsSonar => equip.MasterEquipment.ASW * 2,

			_ => 0
		};
	}
}