// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectMediaMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The geolocation detection results of the video.</para>
        /// <para>This parameter has a value only when the video contains geolocation information.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// <para>The album.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unable</para>
        /// </summary>
        [NameInMap("Album")]
        [Validation(Required=false)]
        public string Album { get; set; }

        /// <summary>
        /// <para>The album artist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unable</para>
        /// </summary>
        [NameInMap("AlbumArtist")]
        [Validation(Required=false)]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// <para>The artist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unable</para>
        /// </summary>
        [NameInMap("Artist")]
        [Validation(Required=false)]
        public string Artist { get; set; }

        /// <summary>
        /// <para>The array of audio streams.</para>
        /// </summary>
        [NameInMap("AudioStreams")]
        [Validation(Required=false)]
        public List<AudioStream> AudioStreams { get; set; }

        /// <summary>
        /// <para>The bitrate of the media file, in bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13164131</para>
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// <para>The composer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unable</para>
        /// </summary>
        [NameInMap("Composer")]
        [Validation(Required=false)]
        public string Composer { get; set; }

        /// <summary>
        /// <para>The total duration of the video, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15.263000</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// <para>The full name of the format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QuickTime / MOV</para>
        /// </summary>
        [NameInMap("FormatLongName")]
        [Validation(Required=false)]
        public string FormatLongName { get; set; }

        /// <summary>
        /// <para>The format name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
        /// </summary>
        [NameInMap("FormatName")]
        [Validation(Required=false)]
        public string FormatName { get; set; }

        /// <summary>
        /// <para>The language used in the video. The value follows the ISO 639-2 standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eng</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The central geographic coordinate point, which is a latitude and longitude value.
        /// The format is latitude,longitude, with latitude first and longitude second. The latitude range is [-90,+90] and the longitude range is [-180,+180]. Example: 35.8,-45.91.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+120.029003,+30.283095</para>
        /// </summary>
        [NameInMap("LatLong")]
        [Validation(Required=false)]
        public string LatLong { get; set; }

        /// <summary>
        /// <para>The performer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unable</para>
        /// </summary>
        [NameInMap("Performer")]
        [Validation(Required=false)]
        public string Performer { get; set; }

        /// <summary>
        /// <para>The time when the video was recorded. The value follows the RFC 3339 Nano standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-24T02:39:57Z</para>
        /// </summary>
        [NameInMap("ProduceTime")]
        [Validation(Required=false)]
        public string ProduceTime { get; set; }

        /// <summary>
        /// <para>The number of programs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ProgramCount")]
        [Validation(Required=false)]
        public long? ProgramCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2213B1A9-EB3D-4666-84E0-24980BC*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The size of the media file, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25115517</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The start playback time of the media, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// <para>The number of media streams.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamCount")]
        [Validation(Required=false)]
        public long? StreamCount { get; set; }

        /// <summary>
        /// <para>The array of subtitle streams.</para>
        /// </summary>
        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public List<SubtitleStream> Subtitles { get; set; }

        /// <summary>
        /// <para>The title of the media file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The height of the video frame in the media file, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("VideoHeight")]
        [Validation(Required=false)]
        public long? VideoHeight { get; set; }

        /// <summary>
        /// <para>The array of video streams.</para>
        /// </summary>
        [NameInMap("VideoStreams")]
        [Validation(Required=false)]
        public List<VideoStream> VideoStreams { get; set; }

        /// <summary>
        /// <para>The width of the video frame in the media file, in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("VideoWidth")]
        [Validation(Required=false)]
        public long? VideoWidth { get; set; }

    }

}
