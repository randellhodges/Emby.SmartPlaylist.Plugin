﻿using System;

namespace SmartPlaylist.Contracts
{
    [Serializable]
    public class SmartPlaylistDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public RuleTreeNodeDto[] RulesTree { get; set; }
        public Guid UserId { get; set; }
        public SmartPlaylistLimitDto Limit { get; set; }
        public DateTimeOffset? LastShuffleUpdate { get; set; } = null;
        public DateTime? LastUpdated { get; set; } = null;
        public DateTime? LastSync { get; set; } = null;
        public string UpdateType { get; set; }
        public string SmartType { get; set; }
        public long InternalId { get; set; }
        public string OriginalSmartType { get; set; }
        public bool ForceCreate { get; set; }
        public string CollectionMode { get; set; }
        public int SyncCount { get; set; }
        public long LastSyncDuration { get; set; } = 0;
        public string Status { get; set; }

    }
}