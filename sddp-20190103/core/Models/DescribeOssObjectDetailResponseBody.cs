// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the OSS storage object.</para>
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// <para>The name of the bucket to which the OSS storage object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucke***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The object type name of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excel</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The name of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The risk level name of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The list of sensitive data detection rules that the OSS storage object hits.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// <para>The object type name of the OSS storage object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Excel</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times the sensitive data detection rule is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The list of data tags for the detection model that is hit.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    /// <summary>
                    /// <para>The data tag ID of the detection model. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>101</b>: personal sensitive information.</description></item>
                    /// <item><description><b>102</b>: personal information.</description></item>
                    /// <item><description><b>103</b>: important data.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The data tag name of the detection model. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Personal sensitive information.</description></item>
                    /// <item><description>Personal information.</description></item>
                    /// <item><description>Important data.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>personal sensitive data</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The risk level ID of the OSS storage object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: No sensitive data is detected.</description></item>
                /// <item><description><b>2</b>: Level 1 sensitive data.</description></item>
                /// <item><description><b>3</b>: Level 2 sensitive data.</description></item>
                /// <item><description><b>4</b>: Level 3 sensitive data.</description></item>
                /// <item><description><b>5</b>: Level 4 sensitive data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                /// <summary>
                /// <para>The risk level name of the OSS storage object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S2</para>
                /// </summary>
                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                /// <summary>
                /// <para>The name of the sensitive data detection rule that is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
