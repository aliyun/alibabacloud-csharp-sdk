// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the OSS object.</para>
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailV2ResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// <para>The name of the bucket that stores the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sddp-api-scan-demo</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The parent category of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sensitive image information</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image file</para>
            /// </summary>
            [NameInMap("FileCategoryName")]
            [Validation(Required=false)]
            public string FileCategoryName { get; set; }

            /// <summary>
            /// <para>The unique ID of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757262735738932224</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The data tags, separated by commas. Example: 101,102. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>101</b>: Personal sensitive information.</para>
            /// </description></item>
            /// <item><description><para><b>102</b>: Personal information.</para>
            /// </description></item>
            /// <item><description><para><b>107</b>: General information.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101,102</para>
            /// </summary>
            [NameInMap("ModelTagIds")]
            [Validation(Required=false)]
            public string ModelTagIds { get; set; }

            /// <summary>
            /// <para>The name of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dir1/test.png</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The access control list (ACL) of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ObjectAcl")]
            [Validation(Required=false)]
            public string ObjectAcl { get; set; }

            /// <summary>
            /// <para>The ID of the region where the OSS object is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the risk level of the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: N/A.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: S1.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: S2.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: S3.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: S4.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A return value of 1 or less indicates N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public int? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the risk level of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>S2</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The list of sensitive data detection rules that the OSS object matches.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList> RuleList { get; set; }
            public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleList : TeaModel {
                /// <summary>
                /// <para>The parent category of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>敏感图片信息</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para>The number of times the sensitive data detection rule was matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>A list of tags for the detection model.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
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
                    /// <para>Personal sensitive information</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The ID of the risk level that is specified in the rule.</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: N/A</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: S1</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: S2</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: S3</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: S4</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                /// <summary>
                /// <para>The name of the risk level that is specified in the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S2</para>
                /// </summary>
                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                /// <summary>
                /// <para>The name of the matched sensitive data detection rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID card number</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>The size of the file in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
