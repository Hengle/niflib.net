/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */
#if OpenTK
using OpenTK;
#elif SharpDX
using SharpDX;
#elif MonoGame
using Microsoft.Xna.Framework;
#endif
using System;
using System.IO;

/// <summary>
/// The Niflib namespace.
/// </summary>
namespace Niflib
{
    /// <summary>
    /// Class NiScreenLODData.
    /// </summary>
    public class NiScreenLODData : NiLODData
	{
        /// <summary>
        /// The bound center
        /// </summary>
        public Vector3 BoundCenter;

        /// <summary>
        /// The bound radius
        /// </summary>
        public float BoundRadius;

        /// <summary>
        /// The world center
        /// </summary>
        public Vector3 WorldCenter;

        /// <summary>
        /// The world radius
        /// </summary>
        public float WorldRadius;

        /// <summary>
        /// The proportion levels
        /// </summary>
        public float[] ProportionLevels;

        /// <summary>
        /// Initializes a new instance of the <see cref="NiScreenLODData"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="reader">The reader.</param>
        public NiScreenLODData(NiFile file, BinaryReader reader) : base(file, reader)
		{
			this.BoundCenter = reader.ReadVector3();
			this.BoundRadius = reader.ReadSingle();
			this.WorldCenter = reader.ReadVector3();
			this.WorldRadius = reader.ReadSingle();
			uint num = reader.ReadUInt32();
			this.ProportionLevels = new float[num];
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				this.ProportionLevels[num2] = reader.ReadSingle();
				num2++;
			}
		}
	}
}
