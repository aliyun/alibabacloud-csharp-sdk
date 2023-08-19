// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsResponseBody : TeaModel {
        /// <summary>
        /// The IDs of canceled jobs.
        /// </summary>
        [NameInMap("CanceledJobs")]
        [Validation(Required=false)]
        public List<string> CanceledJobs { get; set; }

        /// <summary>
        /// The job IDs or upload URLs that do not exist.
        /// 
        /// If you set the request parameter JobIds, the job IDs that do not exist are returned. If you set the request parameter UploadUrls, the upload URLs that do not exist are returned.
        /// </summary>
        [NameInMap("NonExists")]
        [Validation(Required=false)]
        public List<string> NonExists { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
