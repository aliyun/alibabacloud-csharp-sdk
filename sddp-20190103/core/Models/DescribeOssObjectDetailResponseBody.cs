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
            /// <para>The name of the OSS bucket to which the OSS object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bucke***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The type of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excel file</para>
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
            /// <para>The region ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Medium sensitivity level</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>A list of the sensitive data detection rules that the OSS object hits.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// <para>The type of the OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Excel file</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times that the OSS object hits the sensitive data detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>A list of tags for data that hits the recognition model.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    /// <summary>
                    /// <para>The tag ID.</para>
                    /// <list type="bullet">
                    /// <item><description><b>101</b>: sensitive personal information</description></item>
                    /// <item><description><b>102</b>: personal information</description></item>
                    /// <item><description><b>103</b>: important information</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The tag name.</para>
                    /// <list type="bullet">
                    /// <item><description>Sensitive personal information</description></item>
                    /// <item><description>Personal information</description></item>
                    /// <item><description>Important information</description></item>
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
                /// <para>The ID of the sensitivity level of the OSS object.</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: No sensitive data is detected.</description></item>
                /// <item><description><b>2</b>: indicates the low sensitivity level.</description></item>
                /// <item><description><b>3</b>: indicates the medium sensitivity level.</description></item>
                /// <item><description><b>4</b>: indicates the high sensitivity level.</description></item>
                /// <item><description><b>5</b>: indicates the highest sensitivity level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                /// <summary>
                /// <para>The name of the sensitivity level for the OSS object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Medium sensitivity level</para>
                /// </summary>
                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                /// <summary>
                /// <para>The name of the sensitive data detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>\<em>\</em>\* rule</para>
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
