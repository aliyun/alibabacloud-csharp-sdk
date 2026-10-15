// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class DescribeSavingsPlansCoverageTotalResponseBody : TeaModel {
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
        public DescribeSavingsPlansCoverageTotalResponseBodyData Data { get; set; }
        public class DescribeSavingsPlansCoverageTotalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The coverage rate by period.</para>
            /// </summary>
            [NameInMap("PeriodCoverage")]
            [Validation(Required=false)]
            public List<DescribeSavingsPlansCoverageTotalResponseBodyDataPeriodCoverage> PeriodCoverage { get; set; }
            public class DescribeSavingsPlansCoverageTotalResponseBodyDataPeriodCoverage : TeaModel {
                /// <summary>
                /// <para>The coverage rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public float? Percentage { get; set; }

                /// <summary>
                /// <para>The period. Format: yyyyMMddHH.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021071500</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

            }

            /// <summary>
            /// <para>The total coverage rate.</para>
            /// </summary>
            [NameInMap("TotalCoverage")]
            [Validation(Required=false)]
            public DescribeSavingsPlansCoverageTotalResponseBodyDataTotalCoverage TotalCoverage { get; set; }
            public class DescribeSavingsPlansCoverageTotalResponseBodyDataTotalCoverage : TeaModel {
                /// <summary>
                /// <para>The total coverage rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CoveragePercentage")]
                [Validation(Required=false)]
                public float? CoveragePercentage { get; set; }

                /// <summary>
                /// <para>The total offset amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DeductAmount")]
                [Validation(Required=false)]
                public float? DeductAmount { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
