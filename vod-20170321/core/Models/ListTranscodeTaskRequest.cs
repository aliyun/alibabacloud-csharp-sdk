// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListTranscodeTaskRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The number of the page to return. You can specify a page number to return data from the specified page. Default value: **1**.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: **50**. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the audio or video file. You can use one of the following methods to obtain the ID of the file:
        /// *   Log on to the [ApsaraVideo VOD](https://vod.console.aliyun.com) console. In the left-side navigation pane, choose **Media Files** > **Audio/Video**. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.
        /// *   Obtain the value of VideoId from the response to the [CreateUploadVideo](~~55407~~) operation that you call to obtain the upload URL and credential.
        /// *   Obtain the value of VideoId by calling the [SearchMedia](~~86044~~) operation. This method is applicable to files that have been uploaded.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
