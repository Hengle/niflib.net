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
using System;
using System.IO;

/// <summary>
/// The Niflib namespace.
/// </summary>
namespace Niflib
{
    /// <summary>
    /// Class NiTriBasedGeomData.
    /// </summary>
    public class NiTriBasedGeomData : NiGeometryData
	{
        /// <summary>
        /// The number triangles
        /// </summary>
        public ushort NumTriangles;

        /// <summary>
        /// Initializes a new instance of the <see cref="NiTriBasedGeomData"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="reader">The reader.</param>
        public NiTriBasedGeomData(NiFile file, BinaryReader reader) : base(file, reader)
		{
			this.NumTriangles = reader.ReadUInt16();
		}
	}
}
