﻿using System;

namespace StackExchange.Redis
{
    /// <summary>
    /// The class of the connection
    /// </summary>
    public enum ClientType
    {
        /// <summary>
        /// Regular connections, including MONITOR connections
        /// </summary>
        Normal = 0,
        /// <summary>
        /// Replication connections
        /// </summary>
        [Obsolete("Starting with Redis version 5, Redis has moved to 'replica' terminology. Please use " + nameof(Replica) + " instead.")]
        Slave = 1,
        /// <summary>
        /// Replication connections
        /// </summary>
        Replica = 1, // as an implementation detail, note that enum.ToString prefers *later* options when naming Flags
        /// <summary>
        /// Subscription connections
        /// </summary>
        PubSub = 2,
    }
}
