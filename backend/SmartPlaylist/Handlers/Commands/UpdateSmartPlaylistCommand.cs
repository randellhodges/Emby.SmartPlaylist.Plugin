﻿using System;
using SmartPlaylist.Infrastructure.MesssageBus;

namespace SmartPlaylist.Handlers.Commands
{
    public enum ExecutionModes { Scheduled, Manual, OnSave }
    public class UpdateSmartPlaylistCommand : IMessage
    {

        public UpdateSmartPlaylistCommand(Guid smartPlaylistId, ExecutionModes executionMode)
        {
            SmartPlaylistId = smartPlaylistId;
            ExecutionMode = executionMode;
        }

        public Guid SmartPlaylistId { get; }
        public ExecutionModes ExecutionMode { get; }
    }
}