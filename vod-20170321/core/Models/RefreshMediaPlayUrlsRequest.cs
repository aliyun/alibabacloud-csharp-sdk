// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshMediaPlayUrlsRequest : TeaModel {
        /// <summary>
        /// Specifies the resolutions of the media streams you want to refresh or prefetch. You can specify multiple resolutions. Separate multiple resolutions with commas (,). If you leave this parameter empty, media streams in all resolutions are refreshed or prefetched by default.
        /// 
        /// >  The value must be supported in the **Definition** section in [Parameters for media assets](https://help.aliyun.com/document_detail/124671.html).
        /// </summary>
        [NameInMap("Definitions")]
        [Validation(Required=false)]
        public string Definitions { get; set; }

        /// <summary>
        /// The formats of the media streams you want to refresh or prefetch. You can specify multiple formats. Separate multiple formats with commas (,). If you leave this parameter empty, media streams in all formats are refreshed or prefetched by default. Valid values:
        /// 
        /// *   **mp4**
        /// *   **m3u8**
        /// *   **mp3**
        /// *   **flv**
        /// *   **webm**
        /// *   **ts**
        /// </summary>
        [NameInMap("Formats")]
        [Validation(Required=false)]
        public string Formats { get; set; }

        /// <summary>
        /// The IDs of the media files that you want to refresh or prefetch. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload media files.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation that you call to query the media ID after the media file is uploaded.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// Specifies the type of the refresh or prefetch operation. Default value: Single. Valid values:
        /// 
        /// *   **Single**: Only one latest transcoded stream is refreshed or prefetched for each resolution and format.
        /// *   **Multiple**: All transcoded streams are refreshed or prefetched for each resolution and format.
        /// </summary>
        [NameInMap("ResultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        /// <summary>
        /// Specifies the number of the playback URLs of the TS files for the M3U8 media stream you want to refresh or prefetch. After you set this parameter, only the playback URLs of the first N TS files will be refreshed or prefetched. Valid values: 1 to 20. Default value: 5.
        /// </summary>
        [NameInMap("SliceCount")]
        [Validation(Required=false)]
        public int? SliceCount { get; set; }

        /// <summary>
        /// Specifies whether to refresh or prefetch the playback URLs of the TS files of the M3U8 media stream. Default value: false. Valid values:
        /// 
        /// *   **false**
        /// *   **true**
        /// </summary>
        [NameInMap("SliceFlag")]
        [Validation(Required=false)]
        public bool? SliceFlag { get; set; }

        /// <summary>
        /// Specifies the types of media streams you want to refresh or prefetch. You can specify multiple types. Separate multiple types with commas (,). If you leave this parameter empty, media streams in all types are refreshed or prefetched by default. Valid values:
        /// 
        /// *   **video**
        /// *   **audio**
        /// </summary>
        [NameInMap("StreamType")]
        [Validation(Required=false)]
        public string StreamType { get; set; }

        /// <summary>
        /// The type of the task that you want to create. Valid values:
        /// 
        /// *   **Refresh**
        /// *   **Preload**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// The custom configurations such as callback configurations and upload acceleration configurations. The value is a JSON string. For more information, see [Request parameter](https://help.aliyun.com/document_detail/86952.html).
        /// > 
        /// - The callback configurations take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// - You must submit a ticket to enable the upload acceleration feature. For more information, see [Overview](https://help.aliyun.com/document_detail/55396.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
