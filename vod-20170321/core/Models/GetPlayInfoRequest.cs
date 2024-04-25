// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoRequest : TeaModel {
        /// <summary>
        /// The URL of the masked live comment data. Set the value to **danmu**.
        /// 
        /// > This parameter takes effect only when the outputType parameter is set to **cdn**.
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// The validity period of the playback URL. Unit: seconds.
        /// 
        /// *   If you set OutputType to **cdn**:
        /// 
        ///     *   The playback URL has a validity period only if URL signing is enabled. Otherwise, the playback URL is permanently valid. For more information about how to enable and configure URL signing, see [URL signing](~~86090~~).
        ///     *   Minimum value: **1**.
        ///     *   Maximum value: unlimited.
        ///     *   Default value: The default validity period that is specified in URL signing is used.
        /// 
        /// *   If you set OutputType to **oss**:
        /// 
        ///     *   This parameter takes effect only when the ACL of the Object Storage Service (OSS) bucket is private. Otherwise, the playback URL does not expire.
        ///     *   Minimum value: **1**.
        ///     *   Maximum value: If the media file is stored in the VOD bucket, the maximum validity period is **2592000** (30 days). If the media file is stored in an OSS bucket, the maximum validity period is **129600** (36 hours). This limit is imposed to reduce security risks of the origin server. If you require a longer validity period, set OutputType to **cdn** and configure URL signing to specify a longer validity period.
        ///     *   Default value: **3600**.
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

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
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// The type of the digital watermark. Valid values:
        /// 
        /// *   TraceMark: tracing watermark
        /// *   CopyrightMark: copyright watermark
        /// </summary>
        [NameInMap("DigitalWatermarkType")]
        [Validation(Required=false)]
        public string DigitalWatermarkType { get; set; }

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
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// The type of the output URL. Default value: oss. Valid values:
        /// 
        /// *   **oss**
        /// *   **cdn**
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// The custom playback configuration. The value must be a JSON string. You can specify a domain name for playback. For more information, see [PlayConfig](~~86952~~).
        /// 
        /// > *   If you do not set the PlayConfig parameter or the `PlayDomain` parameter that is nested under the PlayConfig parameter, the default domain name specified in ApsaraVideo VOD is used in this operation. If no default domain name is specified, the domain names are queried in reverse chronological order based on the time when the domain names were last modified. To prevent domain name issues, we recommend that you perform the following steps to specify the default playback domain name: Log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Management** > **Storage**. Find the domain name that you want to configure and click **Manage** in the Actions column. On the page that appears, set the default playback domain name in the **Origin Domain Name** section.
        /// >*   If you set the `EncryptType` parameter nested under the PlayConfig parameter to `AliyunVoDEncryption`, the playback URLs of videos encrypted by using Alibaba Cloud proprietary cryptography are not automatically returned to ensure video security. To return playback URLs of videos encrypted by using Alibaba Cloud proprietary cryptography, you must set the `ResultType` parameter to `Multiple`.
        /// </summary>
        [NameInMap("PlayConfig")]
        [Validation(Required=false)]
        public string PlayConfig { get; set; }

        /// <summary>
        /// The CDN reauthentication configuration. The value is a JSON string. If CDN reauthentication is enabled, you can use this parameter to specify the UID and rand fields for URL authentication. For more information, see [URL authentication](~~57007~~).
        /// </summary>
        [NameInMap("ReAuthInfo")]
        [Validation(Required=false)]
        public string ReAuthInfo { get; set; }

        /// <summary>
        /// The type of the data to return. Default value: Single. Valid values:
        /// 
        /// *   **Single**: Only one latest transcoded stream is returned for each quality and format.
        /// *   **Multiple**: All transcoded streams are returned for each quality and format.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// The type of the media stream. Separate multiple types with commas (,). Valid values:
        /// 
        /// *   **video**
        /// *   **audio**
        /// 
        /// By default, video and audio streams are returned.
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// The custom digital watermark.
        /// 
        /// *   If you set `DigitalWatermarkType` to `TraceMark`, specify this parameter to configure the video tracing watermark and return the video stream that contains the watermark. The value can be up to 1,024 characters in length and can contain letters and digits.
        /// *   If you set `DigitalWatermarkType` to `CopyrightMark`, specify the **watermark text** that you created for the watermark template for this parameter.`` You can specify this parameter to query and return the video stream that contains the specified watermark text.
        /// </summary>
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        /// <summary>
        /// The ID of the media file. You can specify only one ID. You can use one of the following methods to obtain the media ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, you can view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the VideoId parameter from the response to the [CreateUploadVideo](~~55407~~) operation.
        /// *   Obtain the value of the VideoId parameter from the response to the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
