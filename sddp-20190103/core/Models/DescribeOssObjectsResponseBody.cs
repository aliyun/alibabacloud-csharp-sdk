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
            /// <para>The name of the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-duplicate-***</para>
            /// </summary>
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <para>The type of the OSS object. Valid values include <b>900001</b>, <b>800015</b>, or <b>800005</b>, which indicates the MP4 file, PDF file, or OSS configuration file, respectively.</para>
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
            /// <para>MP4 file</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The code of the file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FileCategoryCode")]
            [Validation(Required=false)]
            public long? FileCategoryCode { get; set; }

            /// <summary>
            /// <para>The name of the file type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text file</para>
            /// </summary>
            [NameInMap("FileCategoryName")]
            [Validation(Required=false)]
            public string FileCategoryName { get; set; }

            /// <summary>
            /// <para>The file ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>file-22***</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <para>The ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17383</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the OSS object belongs.</para>
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
            /// <para>The region ID of the OSS object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level of the OSS object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
            /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
            /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
            /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
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
            /// <para>The number of rules that are hit.</para>
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
                /// <para>The number of times that the rule is hit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The search keyword. Fuzzy match is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ID card</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the sensitivity level of the OSS object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
                /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
                /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
                /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
                /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
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
            /// <para>The number of fields that are hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The size of the file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("NextMarker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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

        [NameInMap("Truncated")]
        [Validation(Required=false)]
        public bool? Truncated { get; set; }

    }

}
