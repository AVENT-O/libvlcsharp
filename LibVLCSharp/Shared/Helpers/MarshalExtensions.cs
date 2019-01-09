﻿using LibVLCSharp.Shared.Structures;

namespace LibVLCSharp.Shared.Helpers
{
    internal static class MarshalExtensions
    {
        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">AudioOutputDescriptionStructure from interop</param>
        /// <returns>public AudioOutputDescription to be consumed by the user</returns>
        internal static AudioOutputDescription Build(this AudioOutputDescriptionStructure s) => 
            new AudioOutputDescription(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Name) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Description) as string);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">AudioOutputDeviceStructure from interop</param>
        /// <returns>public AudioOutputDevice to be consumed by the user</returns>
        internal static AudioOutputDevice Build(this AudioOutputDeviceStructure s) =>
            new AudioOutputDevice(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.DeviceIdentifier) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Description) as string);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">ModuleDescriptionStructure from interop</param>
        /// <returns>public ModuleDescription to be consumed by the user</returns>
        internal static ModuleDescription Build(this ModuleDescriptionStructure s) =>
            new ModuleDescription(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Name) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.ShortName) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.LongName) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Help) as string);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">TrackDescriptionStructure from interop</param>
        /// <returns>public TrackDescription to be consumed by the user</returns>
        internal static TrackDescription Build(this TrackDescriptionStructure s) =>
            new TrackDescription(s.Id, Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Name) as string);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">MediaSlaveStructure from interop</param>
        /// <returns>public MediaSlave to be consumed by the user</returns>
        internal static MediaSlave Build(this MediaSlaveStructure s) =>
            new MediaSlave(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Uri) as string, s.Type, s.Priority);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">TrackDescriptionStructure from interop</param>
        /// <returns>public TrackDescription to be consumed by the user</returns>
        internal static MediaTrack Build(this MediaTrackStructure s) =>
            new MediaTrack(s.Codec, s.OriginalFourcc, s.Id, s.TrackType, s.Profile, s.Level, s.Data, s.Bitrate,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Language) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Description) as string);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">MediaDiscovererDescriptionStructure from interop</param>
        /// <returns>public MediaDiscovererDescription to be consumed by the user</returns>
        internal static MediaDiscovererDescription Build(this MediaDiscovererDescriptionStructure s) =>
            new MediaDiscovererDescription(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Name) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.LongName) as string,
                s.Category);

        /// <summary>
        /// Helper method that creates a user friendly type from the internal interop structure.
        /// </summary>
        /// <param name="s">RendererDescriptionStructure from interop</param>
        /// <returns>public RendererDescription to be consumed by the user</returns>
        internal static RendererDescription Build(this RendererDescriptionStructure s) =>
            new RendererDescription(Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.Name) as string,
                Utf8StringMarshaler.GetInstance().MarshalNativeToManaged(s.LongName) as string);
    }
}