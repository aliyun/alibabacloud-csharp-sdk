// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaUtilizationOverviewResponseBody : Darabonba.Model {
        /// <summary>
        /// <b>Example:</b>
        /// <para>RAM.PERMISSION.DENIED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>You are not authorized to do this action or the API input parameter is invalid.</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-10-21T07:30:10Z</para>
        /// </summary>
        [NameInMap("GeneratedAt")]
        [Validation(Required=false)]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Quota utilization data is available.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("QuotaOverview")]
        [Validation(Required=false)]
        public GetQuotaUtilizationOverviewResponseBodyQuotaOverview QuotaOverview { get; set; }
        public class GetQuotaUtilizationOverviewResponseBodyQuotaOverview : Darabonba.Model {
            [NameInMap("InUse")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewInUse InUse { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewInUse : Darabonba.Model {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("Over80Percent")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver80Percent Over80Percent { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver80Percent : Darabonba.Model {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            [NameInMap("Over95Percent")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver95Percent Over95Percent { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver95Percent : Darabonba.Model {
                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>920D8A47-26BB-49FA-A09F-F98D7DAA55F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}

