﻿using System.Collections.Generic;
using System.Diagnostics;

namespace dot10.DotNet.MD {
	/// <summary>
	/// Info about one MD table
	/// </summary>
	[DebuggerDisplay("{rowSize} {name}")]
	public sealed class TableInfo {
		Table table;
		int rowSize;
		IList<ColumnInfo> columns;
		string name;

		/// <summary>
		/// Returns the table type
		/// </summary>
		public Table Table {
			get { return table; }
		}

		/// <summary>
		/// Returns the total size of a row in bytes
		/// </summary>
		public int RowSize {
			get { return rowSize; }
			internal set { rowSize = value; }
		}

		/// <summary>
		/// Returns all the columns
		/// </summary>
		public IList<ColumnInfo> Columns {
			get { return columns; }
		}

		/// <summary>
		/// Returns the name of the table
		/// </summary>
		public string Name {
			get { return name; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="table">Table type</param>
		/// <param name="name">Table name</param>
		/// <param name="columns">All columns</param>
		public TableInfo(Table table, string name, IList<ColumnInfo> columns) {
			this.table = table;
			this.name = name;
			this.columns = columns;
		}
	}
}
