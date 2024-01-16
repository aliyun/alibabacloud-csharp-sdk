// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeDistinctReleasesResponseBody : TeaModel {
        /// <summary>
        /// The version information.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribeDistinctReleasesResponseBodyRecords> Records { get; set; }
        public class DescribeDistinctReleasesResponseBodyRecords : TeaModel {
            /// <summary>
            /// The version description.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The MD5 value of the playbook XML configuration.
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
