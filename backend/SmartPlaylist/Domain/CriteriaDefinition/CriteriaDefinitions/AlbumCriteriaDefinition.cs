﻿using MediaBrowser.Controller.Entities.Audio;
using SmartPlaylist.Domain.Rule;
using SmartPlaylist.Domain.Values;

namespace SmartPlaylist.Domain.CriteriaDefinition.CriteriaDefinitions
{
    public class AlbumCriteriaDefinition : CriteriaDefinition
    {
        public override string Name => "Album";
        public override CriteriaDefinitionType Type => StringDefinitionType.Instance;

        public override Value GetValue(UserItem item)
        {
            if (item.Item is Audio audio) return StringValue.Create(audio.Album);

            return Value.None;
        }
    }
}