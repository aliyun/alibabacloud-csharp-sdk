// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoResponseBody : TeaModel {
        /// <summary>
        /// The time base.
        /// </summary>
        [NameInMap("Mezzanine")]
        [Validation(Required=false)]
        public GetMezzanineInfoResponseBodyMezzanine Mezzanine { get; set; }
        public class GetMezzanineInfoResponseBodyMezzanine : TeaModel {
            /// <summary>
            /// The language.
            /// </summary>
            [NameInMap("AudioStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineAudioStreamList> AudioStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineAudioStreamList : TeaModel {
                /// <summary>
                /// The information about the video stream.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The target frame rate.
                /// </summary>
                [NameInMap("ChannelLayout")]
                [Validation(Required=false)]
                public string ChannelLayout { get; set; }

                /// <summary>
                /// The width of the video resolution.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// The time when the file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                /// <summary>
                /// The duration of the video stream.
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// The sequence number of the audio stream, which specifies the position of the audio stream in all audio streams.
                /// </summary>
                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// The tag of the codec format.
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                /// <summary>
                /// The full name of the codec format.
                /// </summary>
                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// The name of the file.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The short name of the codec format.
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The bitrate of the file. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The codec profile.
                /// </summary>
                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                /// <summary>
                /// The status of the file. Valid values:
                /// 
                /// *   **Uploading**: The file is being uploaded. This is the initial status.
                /// *   **Normal**: The file is uploaded.
                /// *   **UploadFail**: The file fails to be uploaded.
                /// *   **Deleted**: The file is deleted.
                /// </summary>
                [NameInMap("SampleFmt")]
                [Validation(Required=false)]
                public string SampleFmt { get; set; }

                /// <summary>
                /// The size of the file. Unit: byte.
                /// </summary>
                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                /// <summary>
                /// The sample rate.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The ID of the video.
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

            }

            /// <summary>
            /// The type of the mezzanine file URL. Valid values:
            /// 
            /// - **oss**: OSS URL
            /// - **cdn** (default): Content Delivery Network (CDN) URL
            /// 
            /// > If the mezzanine file is stored in a bucket of the in type, only an OSS URL is returned.
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// The information about the mezzanine file.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The type of additional information. Separate multiple values with commas (,). By default, only the basic information is returned. Valid values:
            /// 
            /// *   **video**: video stream information
            /// *   **audio**: audio stream information
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The language.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The beginning of the time range that was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// The sample aspect ratio.
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// The height of the video resolution.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// The total number of frames.
            /// </summary>
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            [NameInMap("RestoreStatus")]
            [Validation(Required=false)]
            public string RestoreStatus { get; set; }

            /// <summary>
            /// The duration of the file. Unit: seconds.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The validity period of the mezzanine file URL. Unit: seconds. Default value: **1800**. Minimum value: **1**.
            /// 
            /// *   If the OutputType parameter is set to **cdn**:
            /// 
            ///     *   The mezzanine file URL has a validity period only if URL signing is enabled. Otherwise, the mezzanine file URL is permanently valid.
            ///     *   Minimum value: **1**.
            ///     *   Maximum Value: unlimited.
            ///     *   Default value: If you do not set this parameter, the default validity period that is specified in URL signing is used.
            /// 
            /// <!---->
            /// 
            /// *   If the OutputType parameter is set to **oss**:
            /// 
            ///     *   The mezzanine file URL has a validity period only if the permissions on the Object Storage Service (OSS) bucket are private. Otherwise, the mezzanine file URL is permanently valid.
            ///     *   Minimum value: **1**.
            ///     *   Maximum value: **2592000** (30 days). The maximum value is limited to reduce security risks of the origin.
            ///     *   Default value: If you do not set this parameter, the default value is **3600**.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// The average frame rate.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// The output layout of the sound channels. Valid values:
            /// 
            /// *   **mono**: mono sound channel
            /// *   **stereo**: two sound channels
            /// </summary>
            [NameInMap("VideoStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineVideoStreamList> VideoStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineVideoStreamList : TeaModel {
                /// <summary>
                /// The beginning of the time range that was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AvgFPS")]
                [Validation(Required=false)]
                public string AvgFPS { get; set; }

                /// <summary>
                /// The URL of the file.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The codec time base.
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// The tag string of the codec format.
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// Queries the information about the mezzanine file of an audio or video. The information includes the mezzanine file URL, resolution, and bitrate of the audio or video.
                /// </summary>
                [NameInMap("Dar")]
                [Validation(Required=false)]
                public string Dar { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// The rotation angle of the video. Valid values: **\[0, 360)**.
                /// </summary>
                [NameInMap("HasBFrames")]
                [Validation(Required=false)]
                public string HasBFrames { get; set; }

                /// <summary>
                /// The number of sound channels.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The sequence number of the video stream, which indicates the position of the video stream in all video streams.
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The information about the audio stream.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The time base.
                /// </summary>
                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                /// <summary>
                /// The short name of the codec format.
                /// </summary>
                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The duration of the audio stream.
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// The width of the file. Unit: pixel.
                /// </summary>
                [NameInMap("Sar")]
                [Validation(Required=false)]
                public string Sar { get; set; }

                /// <summary>
                /// The height of the file. Unit: pixel.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The pixel format.
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// The tag of the codec format.
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// The codec time base.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
