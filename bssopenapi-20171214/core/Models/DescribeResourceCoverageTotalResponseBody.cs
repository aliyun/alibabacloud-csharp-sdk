// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeResourceCoverageTotalResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeResourceCoverageTotalResponseBodyData Data { get; set; }
        public class DescribeResourceCoverageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the coverage rate of deduction plans within a period.</para>
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeResourceCoverageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeResourceCoverageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// <para>The coverage rate of deduction plans within the specified period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                /// <summary>
                /// <para>The period.</para>
                /// <para>The value is in the format of yyyyMMddHH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020110100</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

            }

            /// <summary>
            /// <para>The information about the total coverage data of deduction plans.</para>
            /// </summary>
            [NameInMap("TotalCoverage")]
            [Validation(Required=false)]
            public DescribeResourceCoverageTotalResponseBodyDataTotalCoverage TotalCoverage { get; set; }
            public class DescribeResourceCoverageTotalResponseBodyDataTotalCoverage : TeaModel {
                /// <summary>
                /// <para>The unit that is used to measure the resources deducted from deduction plans.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// <para>The total coverage rate of deduction plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                /// <summary>
                /// <para>The total amount of the resources deducted from deduction plans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DeductQuantity")]
                [Validation(Required=false)]
                public float? DeductQuantity { get; set; }

                /// <summary>
                /// <para>The total amount of resources consumed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalQuantity")]
                [Validation(Required=false)]
                public float? TotalQuantity { get; set; }

            }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
