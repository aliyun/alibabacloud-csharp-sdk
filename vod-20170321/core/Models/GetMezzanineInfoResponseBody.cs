// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the source file.
        /// </summary>
        [NameInMap("Mezzanine")]
        [Validation(Required=false)]
        public GetMezzanineInfoResponseBodyMezzanine Mezzanine { get; set; }
        public class GetMezzanineInfoResponseBodyMezzanine : TeaModel {
            /// <summary>
            /// The codec time base.
            /// </summary>
            [NameInMap("AudioStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineAudioStreamList> AudioStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineAudioStreamList : TeaModel {
                /// <summary>
                /// The bitrate.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The output layout of the sound channels. Valid values:
                /// 
                /// *   **mono**
                /// *   **stereo**
                /// </summary>
                [NameInMap("ChannelLayout")]
                [Validation(Required=false)]
                public string ChannelLayout { get; set; }

                /// <summary>
                /// The number of sound channels.
                /// </summary>
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

                /// <summary>
                /// The full name of the encoding format.
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                /// <summary>
                /// The short name of the encoding format.
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// The tag of the encoding format.
                /// </summary>
                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// The tag string of the encoding format.
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                /// <summary>
                /// The codec time base.
                /// </summary>
                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// The duration of the audio file.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The sequence number of the audio stream. The value indicates the position of the audio stream in all audio streams.
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The language.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The total number of frames.
                /// </summary>
                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                /// <summary>
                /// The sampling format.
                /// </summary>
                [NameInMap("SampleFmt")]
                [Validation(Required=false)]
                public string SampleFmt { get; set; }

                /// <summary>
                /// The sampling rate of the audio stream.
                /// </summary>
                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                /// <summary>
                /// The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The time base of the audio stream.
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

            }

            /// <summary>
            /// The bitrate of the file. Unit: Kbit/s.
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// The time when the file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The duration of the file. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The name of the file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The URL of the file.
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// The frame rate of the file. Unit: frames per second.
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// The height of the file. Unit: pixel.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// The type of the mezzanine file URL. Valid values:
            /// 
            /// - **oss**: OSS URL
            /// - **cdn** (default): CDN URL
            /// 
            /// > If you specify an OSS URL for the video stream, the video stream must be in the MP4 format.
            /// </summary>
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }

            /// <summary>
            /// The period of time in which the object remains in the restored state.
            /// </summary>
            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            /// <summary>
            /// The restoration status of the audio or video file. Valid values:
            /// 
            /// *   **Processing**
            /// *   **Success**
            /// *   **Failed**
            /// </summary>
            [NameInMap("RestoreStatus")]
            [Validation(Required=false)]
            public string RestoreStatus { get; set; }

            /// <summary>
            /// The size of the file. Unit: byte.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The status of the file. Valid values:
            /// 
            /// *   **Uploading**: The file is being uploaded. This is the initial status.
            /// *   **Normal**: The file is uploaded.
            /// *   **UploadFail**: The file fails to be uploaded.
            /// *   **Deleted**: The file is deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The storage class of the audio file. Valid values:
            /// 
            /// *   **Standard**: All media resources are stored as Standard objects.
            /// *   **IA**: All media resources are stored as IA objects.
            /// *   **Archive**: All media resources are stored as Archive objects.
            /// *   **ColdArchive**: All media resources are stored as Cold Archive objects.
            /// *   **SourceIA**: Only the source files are IA objects.
            /// *   **SourceArchive**: Only the source files are Archive objects.
            /// *   **SourceColdArchive**: Only the source files are Cold Archive objects.
            /// *   **Changing**: The storage class of the audio file is being changed.
            /// *   **SourceChanging**: The storage class of the source file is being changed.
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// The HDR type of the video stream.
            /// </summary>
            [NameInMap("VideoStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineVideoStreamList> VideoStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineVideoStreamList : TeaModel {
                /// <summary>
                /// The average frame rate.
                /// </summary>
                [NameInMap("AvgFPS")]
                [Validation(Required=false)]
                public string AvgFPS { get; set; }

                /// <summary>
                /// The bitrate. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The full name of the encoding format.
                /// </summary>
                [NameInMap("CodecLongName")]
                [Validation(Required=false)]
                public string CodecLongName { get; set; }

                /// <summary>
                /// The short name of the encoding format.
                /// </summary>
                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                /// <summary>
                /// The tag of the encoding format.
                /// </summary>
                [NameInMap("CodecTag")]
                [Validation(Required=false)]
                public string CodecTag { get; set; }

                /// <summary>
                /// The tag string of the encoding format.
                /// </summary>
                [NameInMap("CodecTagString")]
                [Validation(Required=false)]
                public string CodecTagString { get; set; }

                /// <summary>
                /// The codec time base.
                /// </summary>
                [NameInMap("CodecTimeBase")]
                [Validation(Required=false)]
                public string CodecTimeBase { get; set; }

                /// <summary>
                /// The display aspect ratio (DAR) of the video stream.
                /// </summary>
                [NameInMap("Dar")]
                [Validation(Required=false)]
                public string Dar { get; set; }

                /// <summary>
                /// The duration of the audio file.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The frame rate of the output file.
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The HDR type of the video stream.
                /// </summary>
                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// Indicates whether the video stream contains B-frames.
                /// </summary>
                [NameInMap("HasBFrames")]
                [Validation(Required=false)]
                public string HasBFrames { get; set; }

                /// <summary>
                /// The height of the video stream.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                /// <summary>
                /// The sequence number of the video stream. The value indicates the position of the video stream in all video streams.
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                /// <summary>
                /// The language.
                /// </summary>
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                /// <summary>
                /// The codec level.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The total number of frames.
                /// </summary>
                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                /// <summary>
                /// The pixel format.
                /// </summary>
                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                /// <summary>
                /// The codec profile.
                /// </summary>
                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                /// <summary>
                /// The rotation angle of the video. Valid values: **[0,360)**.
                /// </summary>
                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                /// <summary>
                /// The sample aspect ratio (SAR) of the video stream.
                /// </summary>
                [NameInMap("Sar")]
                [Validation(Required=false)]
                public string Sar { get; set; }

                /// <summary>
                /// The beginning of the time range during which the data was queried. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The time base of the audio stream.
                /// </summary>
                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

                /// <summary>
                /// The width of the video in pixels.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            /// <summary>
            /// The width of the file. Unit: pixel.
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
