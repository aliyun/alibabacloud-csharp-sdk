// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class GetQuotaUtilizationOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RAM.PERMISSION.DENIED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are not authorized to do this action or the API input parameter is invalid.</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The data generation time or statistical date. For general quotas, the time is in UTC and formatted as yyyy-MM-dd\&quot;T\&quot;HH:mm:ss\&quot;Z\&quot;. For API rate limits, the format is yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-21T07:30:10Z</para>
        /// </summary>
        [NameInMap("GeneratedAt")]
        [Validation(Required=false)]
        public string GeneratedAt { get; set; }

        /// <summary>
        /// <para>The supplementary description of the report status. Use Status to determine the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quota utilization data is available.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The quota overview data.</para>
        /// </summary>
        [NameInMap("QuotaOverview")]
        [Validation(Required=false)]
        public GetQuotaUtilizationOverviewResponseBodyQuotaOverview QuotaOverview { get; set; }
        public class GetQuotaUtilizationOverviewResponseBodyQuotaOverview : TeaModel {
            /// <summary>
            /// <para>The quotas in use.</para>
            /// </summary>
            [NameInMap("InUse")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewInUse InUse { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewInUse : TeaModel {
                /// <summary>
                /// <para>The number of adjustable quotas in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <para>The adjustment rate of quotas in use, without the percentage sign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <para>The total number of quotas in use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>The quotas with a utilization rate exceeding 80%.</para>
            /// </summary>
            [NameInMap("Over80Percent")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver80Percent Over80Percent { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver80Percent : TeaModel {
                /// <summary>
                /// <para>The number of adjustable quotas with a utilization rate exceeding 80%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <para>The adjustment rate of quotas with a utilization rate exceeding 80%, without the percentage sign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <para>The number of quotas with a utilization rate exceeding 80%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <para>The quotas with a utilization rate exceeding 95%.</para>
            /// </summary>
            [NameInMap("Over95Percent")]
            [Validation(Required=false)]
            public GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver95Percent Over95Percent { get; set; }
            public class GetQuotaUtilizationOverviewResponseBodyQuotaOverviewOver95Percent : TeaModel {
                /// <summary>
                /// <para>The number of adjustable quotas with a utilization rate exceeding 95%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Adjustable")]
                [Validation(Required=false)]
                public long? Adjustable { get; set; }

                /// <summary>
                /// <para>The adjustment rate of quotas with a utilization rate exceeding 95%, without the percentage sign.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("AdjustableRatio")]
                [Validation(Required=false)]
                public double? AdjustableRatio { get; set; }

                /// <summary>
                /// <para>The number of quotas with a utilization rate exceeding 95%.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>920D8A47-26BB-49FA-A09F-F98D7DAA55F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The query result status of the quota utilization report. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AVAILABLE: The data is available.</para>
        /// </description></item>
        /// <item><description><para>GENERATING: A new report is being generated. If an unexpired historical report exists, the most recent historical report is returned.</para>
        /// </description></item>
        /// <item><description><para>UNAVAILABLE: No general quota report is available. You must call StartQuotaUtilizationReport to start report generation first.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
