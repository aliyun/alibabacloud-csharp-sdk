// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditUsageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68BD3312-53D8-123E-BB32-1A9F25E07A03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The array of usage data.</para>
        /// </summary>
        [NameInMap("UsageInfoList")]
        [Validation(Required=false)]
        public List<DescribeCreditUsageInfoResponseBodyUsageInfoList> UsageInfoList { get; set; }
        public class DescribeCreditUsageInfoResponseBodyUsageInfoList : TeaModel {
            /// <summary>
            /// <para>The usage data details.</para>
            /// </summary>
            [NameInMap("UsageInfo")]
            [Validation(Required=false)]
            public DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfo UsageInfo { get; set; }
            public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfo : TeaModel {
                [NameInMap("AvailableAmount")]
                [Validation(Required=false)]
                public int? AvailableAmount { get; set; }

                [NameInMap("ContactGroupNames")]
                [Validation(Required=false)]
                public List<string> ContactGroupNames { get; set; }

                /// <summary>
                /// <para>The hourly consumption samples of the current credit package.</para>
                /// </summary>
                [NameInMap("CreditTrendList")]
                [Validation(Required=false)]
                public List<DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList> CreditTrendList { get; set; }
                public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList : TeaModel {
                    /// <summary>
                    /// <para>The time point in the format <c>yyyy-MM-dd HH</c> (accurate to the hour).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-05-02 10</para>
                    /// </summary>
                    [NameInMap("TimePoint")]
                    [Validation(Required=false)]
                    public string TimePoint { get; set; }

                    /// <summary>
                    /// <para>The number of credits consumed in this hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("UsedCredit")]
                    [Validation(Required=false)]
                    public long? UsedCredit { get; set; }

                }

                /// <summary>
                /// <para>The instance ID of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-inst-001</para>
                /// </summary>
                [NameInMap("CurrentInstanceId")]
                [Validation(Required=false)]
                public string CurrentInstanceId { get; set; }

                /// <summary>
                /// <para>The remaining credits of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Current period remaining credits</para>
                /// </summary>
                [NameInMap("CurrentRemainCredit")]
                [Validation(Required=false)]
                public long? CurrentRemainCredit { get; set; }

                /// <summary>
                /// <para>The total credits of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Current period credit quota</para>
                /// </summary>
                [NameInMap("CurrentTotalCredit")]
                [Validation(Required=false)]
                public long? CurrentTotalCredit { get; set; }

                /// <summary>
                /// <para>The used credits of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Current period credits consumed</para>
                /// </summary>
                [NameInMap("CurrentUsedCredit")]
                [Validation(Required=false)]
                public long? CurrentUsedCredit { get; set; }

                /// <summary>
                /// <para>The credit usage in the last 1 day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credits consumed in the last day</para>
                /// </summary>
                [NameInMap("DayUsedCredit")]
                [Validation(Required=false)]
                public long? DayUsedCredit { get; set; }

                [NameInMap("LastTriggeredAt")]
                [Validation(Required=false)]
                public string LastTriggeredAt { get; set; }

                /// <summary>
                /// <para>The shared credit quota in the current active period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("PeriodTotalCredit")]
                [Validation(Required=false)]
                public long? PeriodTotalCredit { get; set; }

                /// <summary>
                /// <para>The shared credit usage in the current active period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("PeriodUsedCredit")]
                [Validation(Required=false)]
                public long? PeriodUsedCredit { get; set; }

                /// <summary>
                /// <para>The cumulative remaining credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remaining credits</para>
                /// </summary>
                [NameInMap("RemainCredit")]
                [Validation(Required=false)]
                public long? RemainCredit { get; set; }

                [NameInMap("RemainCreditInfo")]
                [Validation(Required=false)]
                public DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoRemainCreditInfo RemainCreditInfo { get; set; }
                public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoRemainCreditInfo : TeaModel {
                    [NameInMap("DeductingAmount")]
                    [Validation(Required=false)]
                    public int? DeductingAmount { get; set; }

                    [NameInMap("PendingAmount")]
                    [Validation(Required=false)]
                    public int? PendingAmount { get; set; }

                }

                /// <summary>
                /// <para>The quota used today.</para>
                /// </summary>
                [NameInMap("TodayUsed")]
                [Validation(Required=false)]
                public string TodayUsed { get; set; }

                /// <summary>
                /// <para>The total cumulative credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credit quota</para>
                /// </summary>
                [NameInMap("TotalCredit")]
                [Validation(Required=false)]
                public long? TotalCredit { get; set; }

                /// <summary>
                /// <para>The cumulative used quota.</para>
                /// </summary>
                [NameInMap("TotalUsed")]
                [Validation(Required=false)]
                public string TotalUsed { get; set; }

                /// <summary>
                /// <para>The cumulative credit usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Total credits consumed</para>
                /// </summary>
                [NameInMap("TotalUsedCredit")]
                [Validation(Required=false)]
                public long? TotalUsedCredit { get; set; }

                /// <summary>
                /// <para>The alert threshold percentage (0–100).</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("WarnPercent")]
                [Validation(Required=false)]
                public int? WarnPercent { get; set; }

                /// <summary>
                /// <para>The credit usage in the last 1 week.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credits consumed in the last week</para>
                /// </summary>
                [NameInMap("WeekUsedCredit")]
                [Validation(Required=false)]
                public long? WeekUsedCredit { get; set; }

            }

            /// <summary>
            /// <para>The usage primary key. When <c>UsageType=User</c>, this is the <c>aliUid</c>. When <c>UsageType=CreditPackage</c>, this is the credit package instance ID. When <c>UsageType=Agent</c>, this is the <c>AgentId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-abc</para>
            /// </summary>
            [NameInMap("UsageInfoKey")]
            [Validation(Required=false)]
            public string UsageInfoKey { get; set; }

        }

    }

}
