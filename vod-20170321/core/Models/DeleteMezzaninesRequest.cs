// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMezzaninesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the source file. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// 
        /// >  If a video is uploaded without transcoding or is asynchronously transcoded, the source file of the video is used for original-quality playback. By default, the source file of the video cannot be deleted. To forcibly delete the mezzanine file, set this parameter to **true**.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The IDs of audio or video files whose source files that you want to delete. You can specify up to 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the ID:
        /// 
        /// *   After you upload a video in the [ApsaraVideo VOD console](https://vod.console.aliyun.com), you can log on to the ApsaraVideo VOD console and choose **Media Files** > **Audio/Video** to view the ID of the video.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you called to obtain the upload URL and credential.
        /// *   Obtain the value of VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation that you called to query media information after the audio or video file is uploaded.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
