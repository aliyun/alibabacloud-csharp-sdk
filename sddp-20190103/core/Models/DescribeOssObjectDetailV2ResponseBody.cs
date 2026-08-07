// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the OSS storage object.</para>
        /// </summary>
        [NameInMap("OssObjectDetail")]
        [Validation(Required=false)]
        public DescribeOssObjectDetailV2ResponseBodyOssObjectDetail OssObjectDetail { get; set; }
        public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetail : TeaModel {
            /// <summary>
            /// <para>The name of the bucket to which the OSS storage object belongs.</para>
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
            /// <para>The unique ID of the column object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757262735738932224</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The data tags, separated by commas, such as 101,102. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>101</b>: personal sensitive information.</description></item>
            /// <item><description><b>102</b>: personal information.</description></item>
            /// <item><description><b>107</b>: general information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>101,102</para>
            /// </summary>
            [NameInMap("ModelTagIds")]
            [Validation(Required=false)]
            public string ModelTagIds { get; set; }

            /// <summary>
            /// <para>The name of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dir1/test.png</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ACL of the file object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("ObjectAcl")]
            [Validation(Required=false)]
            public string ObjectAcl { get; set; }

            /// <summary>
            /// <para>The region ID of the OSS storage object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The risk level ID of the column data in the data asset table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A.</description></item>
            /// <item><description><b>2</b>: S1.</description></item>
            /// <item><description><b>3</b>: S2.</description></item>
            /// <item><description><b>4</b>: S3.</description></item>
            /// <item><description><b>5</b>: S4.</description></item>
            /// </list>
            /// <remarks>
            /// <para>A return value less than or equal to 1 indicates N/A.</para>
            /// </remarks>
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
            /// <para>The list of sensitive data detection rules that the OSS storage object hits.</para>
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
                /// <para>The number of times the sensitive data detection rule is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The list of data tags.</para>
                /// </summary>
                [NameInMap("ModelTags")]
                [Validation(Required=false)]
                public List<DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags> ModelTags { get; set; }
                public class DescribeOssObjectDetailV2ResponseBodyOssObjectDetailRuleListModelTags : TeaModel {
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
                    /// <para>Personal sensitive information</para>
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
                /// <para>The name of the sensitive data detection rule that is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID card number</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use the request ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
