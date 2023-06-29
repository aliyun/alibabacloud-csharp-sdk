// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribePackagesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the information about the packages.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribePackagesResponseBodyItems> Items { get; set; }
        public class DescribePackagesResponseBodyItems : TeaModel {
            /// <summary>
            /// The point in time when the MaxCompute package was created. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// The ID of the package.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The ID of the instance to which the package belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the package.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The account of the user that owns the package.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// The sensitivity level of the package. Valid values:
            /// 
            /// *   **1**: N/A, which indicates that no sensitive data is detected.
            /// *   **2**: S1, which indicates the low sensitivity level.
            /// *   **3**: S2, which indicates the medium sensitivity level.
            /// *   **4**: S3, which indicates the high sensitivity level.
            /// *   **5**: S4, which indicates the highest sensitivity level.
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// The name of the sensitivity level for the package.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// Indicates whether the package contains sensitive data. Valid values:
            /// 
            /// *   true: yes
            /// *   false: no
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// The total volume of sensitive data in the package. For example, the value can be the total number of sensitive tables in the MaxCompute package.
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// The total volume of data in the package. For example, the value can be the total number of tables in the MaxCompute package.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
