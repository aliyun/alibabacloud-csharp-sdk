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
                /// <summary>
                /// <para>The hourly consumption samples of the current credit package.</para>
                /// </summary>
                [NameInMap("CreditTrendList")]
                [Validation(Required=false)]
                public List<DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList> CreditTrendList { get; set; }
                public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList : TeaModel {
                    /// <summary>
                    /// <para>The time point in the format of <c>yyyy-MM-dd HH</c> (accurate to the hour).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-05-02 10</para>
                    /// </summary>
                    [NameInMap("TimePoint")]
                    [Validation(Required=false)]
                    public string TimePoint { get; set; }

                    /// <summary>
                    /// <para>The number of credits consumed during the hour.</para>
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
                /// <para>当前周期积分余量</para>
                /// </summary>
                [NameInMap("CurrentRemainCredit")]
                [Validation(Required=false)]
                public long? CurrentRemainCredit { get; set; }

                /// <summary>
                /// <para>The total credits of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>当前周期积分配额</para>
                /// </summary>
                [NameInMap("CurrentTotalCredit")]
                [Validation(Required=false)]
                public long? CurrentTotalCredit { get; set; }

                /// <summary>
                /// <para>The used credits of the current active credit package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>当前周期积分消耗</para>
                /// </summary>
                [NameInMap("CurrentUsedCredit")]
                [Validation(Required=false)]
                public long? CurrentUsedCredit { get; set; }

                /// <summary>
                /// <para>The credit usage in the last 1 day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>最近一天消耗积分</para>
                /// </summary>
                [NameInMap("DayUsedCredit")]
                [Validation(Required=false)]
                public long? DayUsedCredit { get; set; }

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
                /// <para>积分余量</para>
                /// </summary>
                [NameInMap("RemainCredit")]
                [Validation(Required=false)]
                public long? RemainCredit { get; set; }

                [NameInMap("TodayUsed")]
                [Validation(Required=false)]
                public string TodayUsed { get; set; }

                /// <summary>
                /// <para>The cumulative total credits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>积分配额</para>
                /// </summary>
                [NameInMap("TotalCredit")]
                [Validation(Required=false)]
                public long? TotalCredit { get; set; }

                [NameInMap("TotalUsed")]
                [Validation(Required=false)]
                public string TotalUsed { get; set; }

                /// <summary>
                /// <para>The cumulative credit usage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>共计消耗积分</para>
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
                /// <para>最近一周消耗积分</para>
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
