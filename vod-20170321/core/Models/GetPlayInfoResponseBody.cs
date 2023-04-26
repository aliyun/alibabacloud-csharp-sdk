// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// The height of the media stream. Unit: pixels.
        /// </summary>
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<GetPlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class GetPlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                [NameInMap("BitDepth")]
                [Validation(Required=false)]
                public int? BitDepth { get; set; }

                /// <summary>
                /// The format of the media stream. Separate multiple formats with commas (,). Valid values:
                /// 
                /// *   **mp4**
                /// *   **m3u8**
                /// *   **mp3**
                /// *   **mpd**
                /// 
                /// > By default, ApsaraVideo VOD returns video streams in all the preceding formats. However, video streams in the MPD format are returned only if the MPD container format is specified in the transcoding template. For more information, see the [Container parameter in the TranscodeTemplate](~~52839~~) table.
                /// </summary>
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                /// <summary>
                /// The status of the media stream. Valid values:
                /// 
                /// *   **Normal**
                /// *   **Invisible**
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The color depth. This value must be an integer.
                /// </summary>
                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                /// <summary>
                /// The encryption type of the media stream. Valid values:
                /// 
                /// *   **AliyunVoDEncryption**: Alibaba Cloud proprietary cryptography
                /// *   **HLSEncryption**: HTTP Live Streaming (HLS) encryption
                /// 
                /// > If the encryption type is**AliyunVoDEncryption**, only ApsaraVideo Player SDK can be used to play videos.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The status of the audio or video file. For more information about the value range and description, see the [Status](~~52839~~) table.
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public long? Encrypt { get; set; }

                /// <summary>
                /// The title of the audio or video file.
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                /// <summary>
                /// Queries the playback URL of a video or audio file by its ID.
                /// </summary>
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// The type of the output URL. Default value: oss. Valid values:
                /// 
                /// *   **oss**
                /// *   **cdn**
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                /// <summary>
                /// The returned result.
                /// </summary>
                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                /// <summary>
                /// The type of the media file. Valid values:
                /// 
                /// *   **video**
                /// *   **audio**
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The validity period of the playback URL. Unit: seconds.
                /// 
                /// *   If the OutputType parameter is set to **cdn**:
                /// 
                ///     *   This parameter takes effect only if URL authentication is enabled. Otherwise, the playback URL does not expire.
                ///     *   Minimum value: **1**.
                ///     *   Maximum value: unlimited.
                ///     *   Default value: The default validity period that is specified in URL authentication is used.
                /// 
                /// *   If the OutputType parameter is set to **oss**:
                /// 
                ///     *   This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the playback URL does not expire.
                ///     *   Minimum value: **1**.
                ///     *   Maximum value: **2592000** (30 days). This limit is imposed to reduce security risks of the origin server.
                ///     *   Default value: **3600**.
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// The type of the data to return. Default value: Single. Valid values:
                /// 
                /// *   **Single**: Only one latest transcoded stream is returned for each quality and format.
                /// *   **Multiple**: All transcoded streams are returned for each quality and format.
                /// </summary>
                [NameInMap("NarrowBandType")]
                [Validation(Required=false)]
                public string NarrowBandType { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("PlayURL")]
                [Validation(Required=false)]
                public string PlayURL { get; set; }

                /// <summary>
                /// The custom playback configuration. The value is a JSON string. For more information, see [PlayConfig](~~86952~~).
                /// 
                /// > 
                /// 
                /// *   If you do not specify PlayConfig or `PlayDomain` in PlayConfig, the default domain name configured in ApsaraVideo VOD is used in this operation. If no default domain name is configured, the domain names are queried in reverse chronological order based on the time when the domain names were modified. The domain name that was last modified is used as the streaming domain name. To prevent domain name issues, we recommend that you specify the default streaming domain name. You can log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com) and choose **Configuration Management** > **Media Management** > **Storage** > **Manage** > **Origin Domain Name** to set the default streaming domain name.
                /// 
                /// *   If the `EncryptType` parameter in PlayConfig is set to `AliyunVoDEncryption`, the playback URL of the stream encrypted by using proprietary cryptography is not returned to ensure video security. If you want to return such URL, you must set the `ResultType` parameter to `Multiple`.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// The size of the media stream. Unit: bytes.
                /// </summary>
                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// The specifications of transcoded audio and video streams. For more information about the valid values, see [Output specifications](~~124671~~).
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The bitrate of the media stream. Unit: Kbit/s.
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                /// <summary>
                /// The quality of the video stream. Separate multiple qualities with commas (,). Valid values:
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
                /// 
                /// > By default, ApsaraVideo VOD returns video streams in all preceding qualities. However, video streams for adaptive bitrate streaming are returned only if the PackageSetting parameter is specified in the transcoding template. For more information, see the [PackageSetting parameter in the TranscodeTemplate](~~52839~~) table.
                /// </summary>
                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                /// <summary>
                /// Indicates whether the video stream was encrypted. Valid values:
                /// 
                /// *   **0**: no
                /// *   **1**: yes
                /// </summary>
                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// The information about the audio or video stream.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The width of the media stream. Unit: pixels.
        /// </summary>
        [NameInMap("VideoBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyVideoBase VideoBase { get; set; }
        public class GetPlayInfoResponseBodyVideoBase : TeaModel {
            /// <summary>
            /// ApsaraVideo VOD
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The type of the media stream. Separate multiple types with commas (,). Valid values:
            /// 
            /// *   **video**
            /// *   **audio**
            /// 
            /// By default, video and audio streams are returned.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The time when the audio or video file was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("DanMuURL")]
            [Validation(Required=false)]
            public string DanMuURL { get; set; }

            /// <summary>
            /// The ID of the watermark that is associated with the media stream.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The ID of the audio or video file. You can use one of the following methods to obtain the ID of the file:
            /// 
            /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, you can view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
            /// *   Obtain the value of the VideoId parameter when you call the [CreateUploadVideo](~~55407~~) operation to upload files.
            /// *   Obtain the value of the VideoId parameter by calling the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// The thumbnail URL of the audio or video file.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The format of the media stream.
            /// 
            /// *   If the media file is a video file, the valid values are **mp4** and **m3u8**.
            /// *   If the media file is an audio-only file, the value is **mp3**.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The type of the media stream. If the media stream is a video stream, the value is **video**. If the media stream is an audio-only stream, the value is **audio**.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
