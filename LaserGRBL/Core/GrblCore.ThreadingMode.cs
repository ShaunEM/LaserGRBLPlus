﻿//Copyright (c) 2016-2021 Diego Settimi - https://github.com/arkypita/

// This program is free software; you can redistribute it and/or modify  it under the terms of the GPLv3 General Public License as published by  the Free Software Foundation; either version 3 of the License, or (at  your option) any later version.
// This program is distributed in the hope that it will be useful, but  WITHOUT ANY WARRANTY; without even the implied warranty of  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GPLv3  General Public License for more details.
// You should have received a copy of the GPLv3 General Public License  along with this program; if not, write to the Free Software  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307,  USA. using System;

using System;

namespace LaserGRBLPlus
{

    [Serializable]
	public class ThreadingMode
	{
		public readonly int StatusQuery;
		public readonly int TxLong;
		public readonly int TxShort;
		public readonly int RxLong;
		public readonly int RxShort;
		private readonly string Name;

		public ThreadingMode(int query, int txlong, int txshort, int rxlong, int rxshort, string name)
		{
			StatusQuery = query;
			TxLong = txlong;
			TxShort = txshort;
			RxLong = rxlong;
			RxShort = rxshort;
			Name = name;
		}

		public static ThreadingMode Slow
		{ get { return new ThreadingMode(2000, 15, 4, 2, 1, "Slow"); } }

		public static ThreadingMode Quiet
		{ get { return new ThreadingMode(1000, 10, 2, 1, 1, "Quiet"); } }

		public static ThreadingMode Fast
		{ get { return new ThreadingMode(500, 5, 1, 1, 0, "Fast"); } }

		public static ThreadingMode UltraFast
		{ get { return new ThreadingMode(250, 1, 0, 0, 0, "UltraFast"); } }

		public static ThreadingMode Insane
		{ get { return new ThreadingMode(200, 1, 0, 0, 0, "Insane"); } }

		public override string ToString()
		{ return Name; }

		public override bool Equals(object obj)
		{ return obj != null && obj is ThreadingMode && ((ThreadingMode)obj).Name == Name; }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}

/*
Idle: All systems are go, no motions queued, and it's ready for anything.
Run: Indicates a cycle is running.
Hold: A feed hold is in process of executing, or slowing down to a stop. After the hold is complete, Grbl will remain in Hold and wait for a cycle start to resume the program.
Door: (New in v0.9i) This compile-option causes Grbl to feed hold, shut-down the spindle and coolant, and wait until the door switch has been closed and the user has issued a cycle start. Useful for OEM that need safety doors.
Home: In the middle of a homing cycle. NOTE: Positions are not updated live during the homing cycle, but they'll be set to the home position once done.
Alarm: This indicates something has gone wrong or Grbl doesn't know its position. This state locks out all G-code commands, but allows you to interact with Grbl's settings if you need to. '$X' kill alarm lock releases this state and puts Grbl in the Idle state, which will let you move things again. As said before, be cautious of what you are doing after an alarm.
Check: Grbl is in check G-code mode. It will process and respond to all G-code commands, but not motion or turn on anything. Once toggled off with another '$C' command, Grbl will reset itself.
*/
