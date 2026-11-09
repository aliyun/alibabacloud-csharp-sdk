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
        /// <para>The business data array.</para>
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
                /// <summary>
                /// <para>The number of currently available instances for the reported resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9976.00</para>
                /// </summary>
                [NameInMap("AvailableAmount")]
                [Validation(Required=false)]
                public int? AvailableAmount { get; set; }

                /// <summary>
                /// <para>The list of contact group names.</para>
                /// </summary>
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
                    /// <para>The time point in the <c>yyyy-MM-dd HH</c> format, accurate to the hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-05-02 10</para>
                    /// </summary>
                    [NameInMap("TimePoint")]
                    [Validation(Required=false)]
                    public string TimePoint { get; set; }

                    /// <summary>
                    /// <para>The number of credits consumed in the hour.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("UsedCredit")]
                    [Validation(Required=false)]
                    public long? UsedCredit { get; set; }

                }

                /// <summary>
                /// <para>The time when the current instance expires, in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-02 00:00:00</para>
                /// </summary>
                [NameInMap("CurrentInstanceExpiredTime")]
                [Validation(Required=false)]
                public string CurrentInstanceExpiredTime { get; set; }

                /// <summary>
                /// <para>The instance ID of the currently active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-inst-001</para>
                /// </summary>
                [NameInMap("CurrentInstanceId")]
                [Validation(Required=false)]
                public string CurrentInstanceId { get; set; }

                /// <summary>
                /// <para>The remaining amount of the currently active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remaining credits for the current period</para>
                /// </summary>
                [NameInMap("CurrentRemainCredit")]
                [Validation(Required=false)]
                public long? CurrentRemainCredit { get; set; }

                /// <summary>
                /// <para>The total amount of the currently active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credit quota for the current period</para>
                /// </summary>
                [NameInMap("CurrentTotalCredit")]
                [Validation(Required=false)]
                public long? CurrentTotalCredit { get; set; }

                /// <summary>
                /// <para>The used amount of the currently active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credits consumed in the current period</para>
                /// </summary>
                [NameInMap("CurrentUsedCredit")]
                [Validation(Required=false)]
                public long? CurrentUsedCredit { get; set; }

                /// <summary>
                /// <para>The credit usage in the last day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credits consumed in the last day</para>
                /// </summary>
                [NameInMap("DayUsedCredit")]
                [Validation(Required=false)]
                public long? DayUsedCredit { get; set; }

                /// <summary>
                /// <para>The last trigger time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-02 10:10:10</para>
                /// </summary>
                [NameInMap("LastTriggeredAt")]
                [Validation(Required=false)]
                public string LastTriggeredAt { get; set; }

                /// <summary>
                /// <para>The credit quota for the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("PeriodCreditQuota")]
                [Validation(Required=false)]
                public long? PeriodCreditQuota { get; set; }

                /// <summary>
                /// <para>The pay-as-you-go credits consumed in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>240</para>
                /// </summary>
                [NameInMap("PeriodPayGoUsedCredit")]
                [Validation(Required=false)]
                public long? PeriodPayGoUsedCredit { get; set; }

                /// <summary>
                /// <para>The shared credits consumed in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("PeriodSharedUsedCredit")]
                [Validation(Required=false)]
                public long? PeriodSharedUsedCredit { get; set; }

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
                /// <para>The total credits consumed in the current period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("PeriodTotalUsedCredit")]
                [Validation(Required=false)]
                public long? PeriodTotalUsedCredit { get; set; }

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
                /// <para>The cumulative remaining billable credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Remaining credits</para>
                /// </summary>
                [NameInMap("RemainCredit")]
                [Validation(Required=false)]
                public long? RemainCredit { get; set; }

                /// <summary>
                /// <para>The remaining credit information.</para>
                /// </summary>
                [NameInMap("RemainCreditInfo")]
                [Validation(Required=false)]
                public DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoRemainCreditInfo RemainCreditInfo { get; set; }
                public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoRemainCreditInfo : TeaModel {
                    /// <summary>
                    /// <para>The number of instances being deducted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23</para>
                    /// </summary>
                    [NameInMap("DeductingAmount")]
                    [Validation(Required=false)]
                    public int? DeductingAmount { get; set; }

                    /// <summary>
                    /// <para>The number of instances pending to take effect.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>24</para>
                    /// </summary>
                    [NameInMap("PendingAmount")]
                    [Validation(Required=false)]
                    public int? PendingAmount { get; set; }

                }

                /// <summary>
                /// <para>The used quota for today.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("TodayUsed")]
                [Validation(Required=false)]
                public string TodayUsed { get; set; }

                /// <summary>
                /// <para>The cumulative total credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credit quota</para>
                /// </summary>
                [NameInMap("TotalCredit")]
                [Validation(Required=false)]
                public long? TotalCredit { get; set; }

                /// <summary>
                /// <para>The cumulative used quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
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
                /// <para>The alert threshold percentage, ranging from 0 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("WarnPercent")]
                [Validation(Required=false)]
                public int? WarnPercent { get; set; }

                /// <summary>
                /// <para>The credit usage in the last week.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Credits consumed in the last week</para>
                /// </summary>
                [NameInMap("WeekUsedCredit")]
                [Validation(Required=false)]
                public long? WeekUsedCredit { get; set; }

            }

            /// <summary>
            /// <para>The primary key for usage. The value is <c>aliUid</c> when <c>UsageType</c> is <c>User</c>, the credit package instance ID when <c>UsageType</c> is <c>CreditPackage</c>, and the agent ID when <c>UsageType</c> is <c>Agent</c>.</para>
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
