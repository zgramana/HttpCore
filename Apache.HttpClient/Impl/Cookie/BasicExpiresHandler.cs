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

using System;
using Apache.Http.Client.Utils;
using Apache.Http.Cookie;
using Apache.Http.Impl.Cookie;
using Apache.Http.Util;
using Sharpen;

namespace Apache.Http.Impl.Cookie
{
	/// <since>4.0</since>
	public class BasicExpiresHandler : AbstractCookieAttributeHandler
	{
		/// <summary>Valid date patterns</summary>
		private readonly string[] datepatterns;

		public BasicExpiresHandler(string[] datepatterns)
		{
			Args.NotNull(datepatterns, "Array of date patterns");
			this.datepatterns = datepatterns;
		}

		/// <exception cref="Apache.Http.Cookie.MalformedCookieException"></exception>
		public override void Parse(SetCookie cookie, string value)
		{
			Args.NotNull(cookie, "Cookie");
			if (value == null)
			{
				throw new MalformedCookieException("Missing value for expires attribute");
			}
			DateTime expiry = DateUtils.ParseDate(value, this.datepatterns);
			if (expiry == null)
			{
				throw new MalformedCookieException("Unable to parse expires attribute: " + value);
			}
			cookie.SetExpiryDate(expiry);
		}
	}
}
