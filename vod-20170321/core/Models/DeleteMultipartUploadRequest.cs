// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMultipartUploadRequest : TeaModel {
        /// <summary>
        /// The ID of the media file, namely, the audio or video ID. You can use one of the following methods to obtain the audio or video ID:
        /// * Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, you can view the audio or video ID. Use this method if the audio or video file is uploaded by using the ApsaraVideo VOD console.
        /// * View the value of the VideoId parameter returned by the [CreateUploadVideo](~~55407~~) operation that you called to obtain an upload URL and credential.
        /// * View the value of the VideoId parameter returned by the [SearchMedia](~~86044~~) operation that you called to query an audio or video ID after the audio or video file is uploaded.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The type of the media file. Set the value to **video**, which indicates audio and video files.
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

    }

}
