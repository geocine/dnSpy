/*
    Copyright (C) 2026 geocine

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnlib.DotNet;

namespace dnSpy.Contracts.Decompiler {
	/// <summary>
	/// Optional member display name provider used by UI formatters outside normal decompiler output.
	/// </summary>
	public interface IDecompilerMemberNameProvider {
		/// <summary>
		/// Returns a custom display name for <paramref name="member"/>, or <c>null</c> to use its metadata name.
		/// </summary>
		/// <param name="member">Member reference</param>
		/// <returns></returns>
		string? GetDisplayName(IMemberRef member);
	}
}
