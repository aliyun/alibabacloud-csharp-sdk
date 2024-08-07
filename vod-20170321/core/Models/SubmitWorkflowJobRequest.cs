// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitWorkflowJobRequest : TeaModel {
        /// <summary>
        /// The ID of the media file. You can use one of the following methods to obtain the ID:
        /// 
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of the VideoId parameter when you call the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation to upload media files.
        /// *   Obtain the value of the VideoId parameter when you call the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation after you upload media files.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The ID of the workflow. To view the ID of the workflow, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com). In the left-side navigation pane, choose **Configuration Management** > **Media Processing** > **Workflows**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
