// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the OSS object.
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// The name of the OSS bucket to which the OSS object belongs.
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// The type of the OSS object.
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

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
            /// The name of the sensitivity level for the OSS object.
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// A list of the sensitive data detection rules that the OSS object hits.
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// The type of the OSS object.
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// The number of times that the OSS object hits the sensitive data detection rule.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// A list of tags for data that hits the recognition model.
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    /// <summary>
                    /// The tag ID.
                    /// 
                    /// *   **101**: sensitive personal information
                    /// *   **102**: personal information
                    /// *   **103**: important information
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The tag name.
                    /// 
                    /// *   Sensitive personal information
                    /// *   Personal information
                    /// *   Important information
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The ID of the sensitivity level of the OSS object.
                /// 
                /// *   **1**: No sensitive data is detected.
                /// *   **2**: indicates the low sensitivity level.
                /// *   **3**: indicates the medium sensitivity level.
                /// *   **4**: indicates the high sensitivity level.
                /// *   **5**: indicates the highest sensitivity level.
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
                /// The name of the sensitive data detection rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
