// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsRequest : TeaModel {
        /// <summary>
        /// The preprocessing type. Set the value to **LivePreprocess**. LivePreprocess specifies that the video is preprocessed in the production studio.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PreprocessType")]
        [Validation(Required=false)]
        public string PreprocessType { get; set; }

        /// <summary>
        /// The ID of the video. You can use one of the following methods to obtain the ID:
        /// 
        /// *   After you upload a video in the ApsaraVideo VOD console, you can log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com) and choose **Media Files** > **Audio/Video** to view the ID of the video.
        /// *   Obtain the VideoId from the response to the [CreateUploadVideo](https://help.aliyun.com/document_detail/55407.html) operation that you call to upload videos.
        /// *   Obtain the VideoId from the response to the [SearchMedia](https://help.aliyun.com/document_detail/86044.html) operation that you call to query videos.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
