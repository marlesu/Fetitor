﻿// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using ScintillaNET;
using System;
using System.Windows.Forms;

namespace Fetitor
{
	class MyScintilla : Scintilla
	{
		public event EventHandler CtrlS;
		public event EventHandler CtrlF;

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Control | Keys.S:
					{
						var ev = this.CtrlS;
						if (ev != null)
							ev(this, null);
						return true;
					}
				case Keys.Control | Keys.F:
					{
						var ev = this.CtrlF;
						if (ev != null)
							ev(this, null);
						return true;
					}
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}
	}
}
