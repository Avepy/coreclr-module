using System;
using AltV.Net.Elements.Entities;

namespace AltV.Net
{
    public partial class Alt
    {
        public static IVoiceChannel CreateVoiceChannel(bool spatial, float maxDistance) =>
            Core.CreateVoiceChannel(spatial, maxDistance);

        [Obsolete("Use channel.Destroy() instead")]
        public static void RemoveVoiceChannel(IVoiceChannel channel) => Core.RemoveVoiceChannel(channel);
    }
}