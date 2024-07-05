// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsRequest : TeaModel {
        /// <summary>
        /// The IDs of the upload jobs. You can obtain the job IDs from PlayInfo in the response to the [GetPlayInfo](https://help.aliyun.com/document_detail/56124.html) operation.
        /// 
        /// *   You can specify a maximum of 10 IDs.
        /// *   Separate multiple IDs with commas (,).
        /// 
        /// >  You must specify either JobIds or UploadUrls. If you specify both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// The upload URLs of source video files. Separate multiple URLs with commas (,). You can specify a maximum of 10 URLs.
        /// 
        /// > *   You must encode the URLs before you use the URLs.
        /// > *   You must specify either JobIds or UploadUrls. If you specify both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("UploadUrls")]
        [Validation(Required=false)]
        public string UploadUrls { get; set; }

    }

}
