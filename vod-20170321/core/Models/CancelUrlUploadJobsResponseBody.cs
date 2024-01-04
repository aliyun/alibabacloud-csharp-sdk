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
        /// The jobs that do not exist.
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
