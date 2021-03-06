﻿using Kerosene.Tools;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace Kerosene.ORM.Direct
{
	// ==================================================== 
	/// <summary>
	/// Represents the type of an underlying database engine in a direct connection scenario.
	/// </summary>
	public interface IDataEngine : Core.IDataEngine
	{
		/// <summary>
		/// Returns a new instance that is a copy of the original one.
		/// </summary>
		/// <returns>A new instance.</returns>
		new IDataEngine Clone();

		/// <summary>
		/// Returns a new instance that is a copy of the original one.
		/// </summary>
		/// <param name="settings">A dictionary containing the names and values of the properties
		/// that has to be changed with respect to the original ones, or null if these changes
		/// are not needed.</param>
		/// <returns>A new instance.</returns>
		new IDataEngine Clone(IDictionary<string, object> settings);

		/// <summary>
		/// Gets the provider factory associated with this engine.
		/// </summary>
		DbProviderFactory ProviderFactory { get; }
	}
}
