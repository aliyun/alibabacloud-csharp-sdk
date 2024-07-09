// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class StartJobRunResponseBody : TeaModel {
        /// <summary>
        /// The job ID.
        /// </summary>
        [NameInMap("jobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
