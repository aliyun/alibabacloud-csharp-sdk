// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeSummaryRequest : TeaModel {
        /// <summary>
        /// The ID of the audio or video file. You can specify up to 10 IDs. Separate the IDs with commas (,). You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](~~55407~~) operation that you call to obtain the upload URL and credential.
        /// *   Obtain the value of VideoId by calling the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
