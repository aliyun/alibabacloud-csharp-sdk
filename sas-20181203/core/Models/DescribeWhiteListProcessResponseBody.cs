// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListProcessResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The information about the processes.
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<DescribeWhiteListProcessResponseBodyProcesses> Processes { get; set; }
        public class DescribeWhiteListProcessResponseBodyProcesses : TeaModel {
            /// <summary>
            /// The path to the process startup file.
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// The primary key of the process information.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The trust score of the process.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            /// <summary>
            /// The MD5 hash value of the process startup file.
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

            /// <summary>
            /// The ID of the process.
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public int? ProcessId { get; set; }

            /// <summary>
            /// The name of the process.
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// The type of the process. Valid values:
            /// 
            /// *   **1**: trusted
            /// *   **2**: suspicious
            /// *   **3**: malicious
            /// </summary>
            [NameInMap("ProcessType")]
            [Validation(Required=false)]
            public int? ProcessType { get; set; }

            /// <summary>
            /// Indicates whether the process is trusted. Valid values:
            /// 
            /// *   **1**: no
            /// *   **2**: yes
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
