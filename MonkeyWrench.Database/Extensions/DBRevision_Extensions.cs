/*
 * DBRevision_Extensions.cs
 *
 * Authors:
 *   Rolf Bjarne Kvinge (RKvinge@novell.com)
 *   
 * Copyright 2009 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 *
 */

using MonkeyWrench.DataClasses;

namespace MonkeyWrench.Database
{
	public static class DBRevision_Extensions
	{
		public static DBRevision Create (DB db, int id)
		{
			return DBRecord_Extensions.Create (db, new DBRevision (), DBRevision.TableName, id);
		}

		public static DBRevision Load(DB db, int id)
		{
			return DBRecord_Extensions.Load<DBRevision> (db, DBRevision.TableName, id);
		}
	}
}
