// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DescribeProductsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProductsResponseBodyData Data { get; set; }
        public class DescribeProductsResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeProductsResponseBodyDataContent> Content { get; set; }
            public class DescribeProductsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckFailedCount")]
                [Validation(Required=false)]
                public long? CheckFailedCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckFailedResourceCount")]
                [Validation(Required=false)]
                public long? CheckFailedResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DisableCheckResourceCount")]
                [Validation(Required=false)]
                public long? DisableCheckResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableCheck")]
                [Validation(Required=false)]
                public bool? EnableCheck { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("ProtectionScore")]
                [Validation(Required=false)]
                public int? ProtectionScore { get; set; }

                [NameInMap("ProtectionScoreDistribution")]
                [Validation(Required=false)]
                public List<DescribeProductsResponseBodyDataContentProtectionScoreDistribution> ProtectionScoreDistribution { get; set; }
                public class DescribeProductsResponseBodyDataContentProtectionScoreDistribution : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    [NameInMap("Range")]
                    [Validation(Required=false)]
                    public DescribeProductsResponseBodyDataContentProtectionScoreDistributionRange Range { get; set; }
                    public class DescribeProductsResponseBodyDataContentProtectionScoreDistributionRange : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("From")]
                        [Validation(Required=false)]
                        public int? From { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("To")]
                        [Validation(Required=false)]
                        public int? To { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1726036498</para>
                /// </summary>
                [NameInMap("ProtectionScoreUpdatedTime")]
                [Validation(Required=false)]
                public long? ProtectionScoreUpdatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskCount")]
                [Validation(Required=false)]
                public long? RiskCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskyResourceCount")]
                [Validation(Required=false)]
                public long? RiskyResourceCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalResourceCount")]
                [Validation(Required=false)]
                public long? TotalResourceCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b4fd3cffcacafd65e3818a0b9b2ff9a2</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30FB202A-1D22-5394-AB02-4477CDFCF51F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
