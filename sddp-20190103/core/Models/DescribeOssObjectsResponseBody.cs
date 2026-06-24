// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeOssObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of OSS objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeOssObjectsResponseBodyItems> Items { get; set; }
        public class DescribeOssObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The bucket name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-duplicate-***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The type of the OSS object, such as <b>900001</b> (MP4 video file), <b>800015</b> (PDF document), and <b>800005</b> (OSS configuration file).</para>
            /// 
            /// <b>Example:</b>
            /// <para>900001</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public long? Category { get; set; }

            /// <summary>
            /// <para>The name of the file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MP4</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The code of the file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FileCategoryCode")]
            [Validation(Required=false)]
            public long? FileCategoryCode { get; set; }

            /// <summary>
            /// <para>The name of the file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text file</para>
            /// </summary>
            [NameInMap("FileCategoryName")]
            [Validation(Required=false)]
            public string FileCategoryName { get; set; }

            /// <summary>
            /// <para>The ID of the OSS file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file-22***</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The unique ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17383</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the asset instance to which the OSS object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232122</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the file was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

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
            /// <para>The region ID of the OSS object owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The risk level ID of the OSS object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: N/A. No sensitive data is detected.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: S1. Level 1 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: S2. Level 2 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: S3. Level 3 sensitive data.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: S4. Level 4 sensitive data.</para>
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
            /// <para>High risk</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The number of matched rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// <para>A list of rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeOssObjectsResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeOssObjectsResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>The number of times the rule is matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID card</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The risk level ID of the rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: N/A. No sensitive data is detected.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: S1. Level 1 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: S2. Level 2 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: S3. Level 3 sensitive data.</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: S4. Level 4 sensitive data.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

            }

            /// <summary>
            /// <para>The number of matched fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The token that marks the start of the next page of results.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <c>Truncated</c> is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1754786235714378752</para>
        /// </summary>
        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>Indicates whether the results are truncated. The default value is false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The results are truncated.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The results are not truncated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Truncated")]
        [Validation(Required=false)]
        public bool? Truncated { get; set; }

    }

}
