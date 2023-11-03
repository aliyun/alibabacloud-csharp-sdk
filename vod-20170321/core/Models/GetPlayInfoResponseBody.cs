// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// The information about the audio or video stream.
        /// </summary>
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<GetPlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class GetPlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                /// <summary>
                /// The color depth. This value must be an integer.
                /// </summary>
                [NameInMap("BitDepth")]
                [Validation(Required=false)]
                public int? BitDepth { get; set; }

                /// <summary>
                /// The bitrate of the media stream. Unit: Kbit/s.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The time when the audio or video stream was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The quality of the media stream. Valid values:
                /// 
                /// *   **FD**: low definition
                /// *   **LD**: standard definition
                /// *   **SD**: high definition
                /// *   **HD**: ultra-high definition
                /// *   **OD**: original definition
                /// *   **2K**: 2K
                /// *   **4K**: 4K
                /// *   **SQ**: standard sound quality
                /// *   **HQ**: high sound quality
                /// *   **AUTO**: adaptive bitrate
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// The duration of the media stream. Unit: seconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// Indicates whether the media stream is encrypted. Valid values:
                /// 
                /// *   **0**: The media stream is not encrypted.
                /// *   **1**: The media stream is encrypted.
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public long? Encrypt { get; set; }

                /// <summary>
                /// The encryption type of the media stream. Valid values:
                /// 
                /// *   **AliyunVoDEncryption**: Alibaba Cloud proprietary cryptography
                /// *   **HLSEncryption**: HTTP Live Streaming (HLS) encryption
                /// 
                /// >  If the encryption type is AliyunVoDEncryption, only ApsaraVideo Player SDK can be used to play videos.
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                /// <summary>
                /// The format of the media stream.
                /// 
                /// *   If the media file is a video file, the valid values are **mp4** and **m3u8**.
                /// *   If the media file is an audio-only file, the value is **mp3**.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The frame rate of the media stream. Unit: frames per second.
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                /// <summary>
                /// The HDR type of the media stream. Valid values:
                /// 
                /// *   HDR
                /// *   HDR10
                /// *   HLG
                /// *   DolbyVision
                /// *   HDRVivid
                /// *   SDR+
                /// </summary>
                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// The height of the media stream. Unit: pixels.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// The custom watermark information of the copyright watermark. This parameter is returned if you set `JobType` to `2`.
                /// </summary>
                [NameInMap("JobExt")]
                [Validation(Required=false)]
                public string JobExt { get; set; }

                /// <summary>
                /// The job ID for transcoding the media stream. This ID uniquely identifies a media stream.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The type of the digital watermark. Valid values:
                /// 
                /// *   **1**: tracing watermark
                /// *   **2**: copyright watermark
                /// </summary>
                [NameInMap("JobType")]
                [Validation(Required=false)]
                public int? JobType { get; set; }

                /// <summary>
                /// The update time. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The type of Narrowband HD transcoding. Valid values:
                /// 
                /// *   **0**: normal transcoding
                /// *   **1.0**: Narrowband HD 1.0
                /// *   **2.0**: Narrowband HD 2.0
                /// 
                /// This parameter is returned only when a quality that is available in the built-in Narrowband HD 1.0 transcoding template is specified. For more information, see the [Definition parameter in the TranscodeTemplate](~~52839~~) table.
                /// </summary>
                [NameInMap("NarrowBandType")]
                [Validation(Required=false)]
                public string NarrowBandType { get; set; }

                /// <summary>
                /// The playback URL of the media stream.
                /// </summary>
                [NameInMap("PlayURL")]
                [Validation(Required=false)]
                public string PlayURL { get; set; }

                /// <summary>
                /// The size of the media stream. Unit: bytes.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The specifications of transcoded audio and video streams. For more information about the valid values, see [Output specifications](~~124671~~).
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// The status of the audio or video stream. Valid values:
                /// 
                /// *   **Normal**: The latest transcoded stream in each quality and format is in the Normal status.
                /// *   **Invisible**: If multiple streams are transcoded in the same quality and format, the latest transcoded stream is in the Normal status and other streams are in the Invisible status.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the media stream. If the media stream is a video stream, the value is **video**. If the media stream is an audio-only stream, the value is **audio**.
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// The ID of the watermark that is associated with the media stream.
                /// </summary>
                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                /// <summary>
                /// The width of the media stream. Unit: pixels.
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The basic information about the audio or video file.
        /// </summary>
        [NameInMap("VideoBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyVideoBase VideoBase { get; set; }
        public class GetPlayInfoResponseBodyVideoBase : TeaModel {
            /// <summary>
            /// The thumbnail URL of the audio or video file.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the audio or video file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The URL of the masked live comment data.
            /// </summary>
            [NameInMap("DanMuURL")]
            [Validation(Required=false)]
            public string DanMuURL { get; set; }

            /// <summary>
            /// The duration of the audio or video file. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The type of the media file. Valid values:
            /// 
            /// *   **video**
            /// *   **audio**
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// The status of the audio or video file. For more information about the value range and description, see the [Status](~~52839~~) table.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The title of the audio or video file.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The ID of the media file.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
