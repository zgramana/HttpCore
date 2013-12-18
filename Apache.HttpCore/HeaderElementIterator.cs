/**
 * Couchbase Lite for .NET
 *
 * Original iOS version by Jens Alfke
 * Android Port by Marty Schoch, Traun Leyden
 * C# Port by Zack Gramana
 *
 * Copyright (c) 2012, 2013 Couchbase, Inc. All rights reserved.
 * Portions (c) 2013 Xamarin, Inc. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

using System.Collections.Generic;
using Org.Apache.Http;
using Sharpen;

namespace Org.Apache.Http
{
	/// <summary>
	/// A type-safe iterator for
	/// <see cref="HeaderElement">HeaderElement</see>
	/// objects.
	/// </summary>
	/// <since>4.0</since>
	public interface HeaderElementIterator : IEnumerator<object>
	{
		/// <summary>
		/// Indicates whether there is another header element in this
		/// iteration.
		/// </summary>
		/// <remarks>
		/// Indicates whether there is another header element in this
		/// iteration.
		/// </remarks>
		/// <returns>
		/// <code>true</code> if there is another header element,
		/// <code>false</code> otherwise
		/// </returns>
		bool HasNext();

		/// <summary>Obtains the next header element from this iteration.</summary>
		/// <remarks>
		/// Obtains the next header element from this iteration.
		/// This method should only be called while
		/// <see cref="HasNext()">hasNext</see>
		/// is true.
		/// </remarks>
		/// <returns>the next header element in this iteration</returns>
		HeaderElement NextElement();
	}
}
