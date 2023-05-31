// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWebPathResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the paths to the web directories.
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public List<DescribeWebPathResponseBodyConfigList> ConfigList { get; set; }
        public class DescribeWebPathResponseBodyConfigList : TeaModel {
            /// <summary>
            /// An array consisting of the servers on which the web directories are scanned.
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeWebPathResponseBodyConfigListTargetList> TargetList { get; set; }
            public class DescribeWebPathResponseBodyConfigListTargetList : TeaModel {
                /// <summary>
                /// The object.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The object type. Valid values:
                /// 
                /// *   **uuid**
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The path to the web directory.
            /// </summary>
            [NameInMap("WebPath")]
            [Validation(Required=false)]
            public string WebPath { get; set; }

            /// <summary>
            /// The path type of the web directory. Valid values:
            /// 
            /// *   **def**: automatically identified
            /// *   **customize**: manually added
            /// </summary>
            [NameInMap("WebPathType")]
            [Validation(Required=false)]
            public string WebPathType { get; set; }

        }

        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
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
