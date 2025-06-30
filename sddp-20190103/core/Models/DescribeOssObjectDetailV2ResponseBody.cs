// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Detailed information about the OSS storage object.</para>
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailV2ResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// <para>The name of the Bucket to which the OSS storage object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sddp-api-scan-demo</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The major category of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Excel file</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>File type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text file</para>
            /// </summary>
            [NameInMap("FileCategoryName")]
            [Validation(Required=false)]
            public string FileCategoryName { get; set; }

            /// <summary>
            /// <para>The unique ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757262735738932224</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Data labels, separated by commas. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>101</b>: Personal Sensitive Information.</description></item>
            /// <item><description><b>102</b>: Personal Information.</description></item>
            /// <item><description><b>107</b>: General Information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101,102</para>
            /// </summary>
            [NameInMap("ModelTagIds")]
            [Validation(Required=false)]
            public string ModelTagIds { get; set; }

            /// <summary>
            /// <para>OSS storage object name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dir1/test.png</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>OSS Object ACL</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ObjectAcl")]
            [Validation(Required=false)]
            public string ObjectAcl { get; set; }

            /// <summary>
            /// <para>The region ID to which the OSS storage object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the OSS object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
            /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
            /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
            /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public int? RiskLevelId { get; set; }

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
            /// <para>A list of sensitive data recognition rules hit by the OSS storage object.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// <para>The major category of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Excel</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times the sensitive data recognition rule was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>List of data tags.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
                    /// <summary>
                    /// <para>ID of the data label for the recognition model.</para>
                    /// <list type="bullet">
                    /// <item><description><b>101</b>: Personal sensitive information.</description></item>
                    /// <item><description><b>102</b>: Personal information.</description></item>
                    /// <item><description><b>103</b>: Important data.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>Name of the data label for the recognition model.</para>
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
                /// <para>The risk level ID of the OSS storage object.</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: No sensitive data detected.</description></item>
                /// <item><description><b>2</b>: Level 1 sensitive data.</description></item>
                /// <item><description><b>3</b>: Level 2 sensitive data.</description></item>
                /// <item><description><b>4</b>: Level 3 sensitive data.</description></item>
                /// <item><description><b>5</b>: Level 4 sensitive data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
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
                /// <para>The name of the sensitive data recognition rule that was hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>File size. Unit: Byte.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
