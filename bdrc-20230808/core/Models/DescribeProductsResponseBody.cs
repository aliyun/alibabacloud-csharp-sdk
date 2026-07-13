// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeProductsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProductsResponseBodyData Data { get; set; }
        public class DescribeProductsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of cloud products and their data protection status.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeProductsResponseBodyDataContent> Content { get; set; }
            public class DescribeProductsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The count of failed check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckFailedCount")]
                [Validation(Required=false)]
                public long? CheckFailedCount { get; set; }

                /// <summary>
                /// <para>The count of resources that failed the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckFailedResourceCount")]
                [Validation(Required=false)]
                public long? CheckFailedResourceCount { get; set; }

                /// <summary>
                /// <para>The count of resources for which the check is disabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DisableCheckResourceCount")]
                [Validation(Required=false)]
                public long? DisableCheckResourceCount { get; set; }

                /// <summary>
                /// <para>Indicates whether the data protection score is enabled for the cloud product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableCheck")]
                [Validation(Required=false)]
                public bool? EnableCheck { get; set; }

                /// <summary>
                /// <para>The cloud product type, such as <c>ECS</c> and <c>OSS</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The data protection score, ranging from 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("ProtectionScore")]
                [Validation(Required=false)]
                public int? ProtectionScore { get; set; }

                /// <summary>
                /// <para>The distribution of resources across different score ranges.</para>
                /// </summary>
                [NameInMap("ProtectionScoreDistribution")]
                [Validation(Required=false)]
                public List<DescribeProductsResponseBodyDataContentProtectionScoreDistribution> ProtectionScoreDistribution { get; set; }
                public class DescribeProductsResponseBodyDataContentProtectionScoreDistribution : TeaModel {
                    /// <summary>
                    /// <para>The count of resources within this score range.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The score range.</para>
                    /// </summary>
                    [NameInMap("Range")]
                    [Validation(Required=false)]
                    public DescribeProductsResponseBodyDataContentProtectionScoreDistributionRange Range { get; set; }
                    public class DescribeProductsResponseBodyDataContentProtectionScoreDistributionRange : TeaModel {
                        /// <summary>
                        /// <para>The lower bound of the score range, inclusive.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <para>The upper bound of the score range, inclusive.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                    }

                }

                /// <summary>
                /// <para>The UNIX timestamp of the last data protection score update.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1726036498</para>
                /// </summary>
                [NameInMap("ProtectionScoreUpdatedTime")]
                [Validation(Required=false)]
                public long? ProtectionScoreUpdatedTime { get; set; }

                /// <summary>
                /// <para>The count of risky check items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public long? RiskCount { get; set; }

                /// <summary>
                /// <para>The count of risky resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskyResourceCount")]
                [Validation(Required=false)]
                public long? RiskyResourceCount { get; set; }

                /// <summary>
                /// <para>The total count of resources for the cloud product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

                /// <summary>
                /// <para>The count of resources pending a check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WaitForCheckResourceCount")]
                [Validation(Required=false)]
                public long? WaitForCheckResourceCount { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The token for the next page of results. If this parameter is absent from the response, all results have been retrieved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b4fd3cffcacafd65e3818a0b9b2ff9a2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries that match the query. This parameter is not returned by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30FB202A-1D22-5394-AB02-4477CDFCF51F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
