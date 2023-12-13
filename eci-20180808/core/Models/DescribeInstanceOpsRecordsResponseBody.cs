// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeInstanceOpsRecordsResponseBody : TeaModel {
        /// <summary>
        /// The details of the O\&M tasks.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeInstanceOpsRecordsResponseBodyRecords> Records { get; set; }
        public class DescribeInstanceOpsRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// The time when the O\&M task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the O\&M task expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The status of the O\&M task.
            /// </summary>
            [NameInMap("OpsStatus")]
            [Validation(Required=false)]
            public string OpsStatus { get; set; }

            /// <summary>
            /// The type of the O\&M task.
            /// </summary>
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }

            /// <summary>
            /// The content of the O\&M result. The content is the download URL of the files that are generated for the O\&M task.
            /// </summary>
            [NameInMap("ResultContent")]
            [Validation(Required=false)]
            public string ResultContent { get; set; }

            /// <summary>
            /// The type of the O\&M result. Valid value: OSS. This value indicates that the files generated for the O\&M task are saved to Object Storage Service (OSS) buckets.
            /// </summary>
            [NameInMap("ResultType")]
            [Validation(Required=false)]
            public string ResultType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
