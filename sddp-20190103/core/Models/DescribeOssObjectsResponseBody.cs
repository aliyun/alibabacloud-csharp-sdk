// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// A list of OSS objects.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeOssObjectsResponseBodyItems> Items { get; set; }
        public class DescribeOssObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the bucket.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The type of the OSS object. Valid values include **900001**, **800015**, or **800005**, which indicates the MP4 file, PDF file, or OSS configuration file, respectively.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// The name of the file type.
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// The code of the file type.
            /// </summary>
            [NameInMap("FileCategoryCode")]
            [Validation(Required=false)]
            public long? FileCategoryCode { get; set; }

            /// <summary>
            /// The name of the file type.
            /// </summary>
            [NameInMap("FileCategoryName")]
            [Validation(Required=false)]
            public string FileCategoryName { get; set; }

            /// <summary>
            /// The file ID of the OSS object.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// The ID of the OSS object.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the instance to which the OSS object belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The time when the file was last modified.
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// The name of the OSS object.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The region ID of the OSS object.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the sensitivity level of the OSS object. Valid values:
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
            /// The name of the sensitivity level for the OSS object.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// The number of rules that are hit.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// A list of rules.
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectsResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeOssObjectsResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// The number of times that the rule is hit.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The search keyword. Fuzzy match is supported.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the sensitivity level of the OSS object. Valid values:
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

            }

            /// <summary>
            /// The number of fields that are hit.
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// The size of the file. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

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
