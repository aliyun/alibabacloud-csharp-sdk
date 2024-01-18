// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeImportedLogCountResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImportedLogCountResponseBodyData Data { get; set; }
        public class DescribeImportedLogCountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of logs that are added.
            /// </summary>
            [NameInMap("ImportedLogCount")]
            [Validation(Required=false)]
            public int? ImportedLogCount { get; set; }

            /// <summary>
            /// The total number of logs.
            /// </summary>
            [NameInMap("TotalLogCount")]
            [Validation(Required=false)]
            public int? TotalLogCount { get; set; }

            /// <summary>
            /// The number of logs that are not added.
            /// </summary>
            [NameInMap("UnImportedLogCount")]
            [Validation(Required=false)]
            public int? UnImportedLogCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
