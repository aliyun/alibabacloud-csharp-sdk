// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the OSS object.</para>
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// <para>The name of the bucket to which the OSS object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucke***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The name of the OSS object type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excel</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The name of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region where the OSS object is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the risk level for the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>A list of sensitive data detection rules that the OSS object hits.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// <para>The name of the OSS object type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Excel</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times the sensitive data detection rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>A list of data tags that are hit by the detection model.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    /// <summary>
                    /// <para>The ID of the data tag for the detection model.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>101</b>: Personal sensitive information.</para>
                    /// </description></item>
                    /// <item><description><para><b>102</b>: Personal information.</para>
                    /// </description></item>
                    /// <item><description><para><b>103</b>: Important data.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the data tag for the detection model.</para>
                    /// <list type="bullet">
                    /// <item><description><para>Personal sensitive information.</para>
                    /// </description></item>
                    /// <item><description><para>Personal information.</para>
                    /// </description></item>
                    /// <item><description><para>Important data.</para>
                    /// </description></item>
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
                /// <para>The ID of the risk level for the OSS object.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: No sensitive data is detected.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: Level 1 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: Level 2 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: Level 3 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: Level 4 sensitive data.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                /// <summary>
                /// <para>The name of the risk level for the OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S2</para>
                /// </summary>
                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                /// <summary>
                /// <para>The name of the sensitive data detection rule that was hit.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
