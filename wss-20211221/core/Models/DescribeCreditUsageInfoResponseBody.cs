// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wss20211221.Models
{
    public class DescribeCreditUsageInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>68BD3312-53D8-123E-BB32-1A9F25E07A03</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageInfoList")]
        [Validation(Required=false)]
        public List<DescribeCreditUsageInfoResponseBodyUsageInfoList> UsageInfoList { get; set; }
        public class DescribeCreditUsageInfoResponseBodyUsageInfoList : TeaModel {
            [NameInMap("UsageInfo")]
            [Validation(Required=false)]
            public DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfo UsageInfo { get; set; }
            public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfo : TeaModel {
                [NameInMap("CreditTrendList")]
                [Validation(Required=false)]
                public List<DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList> CreditTrendList { get; set; }
                public class DescribeCreditUsageInfoResponseBodyUsageInfoListUsageInfoCreditTrendList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-05-02 10</para>
                    /// </summary>
                    [NameInMap("TimePoint")]
                    [Validation(Required=false)]
                    public string TimePoint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("UsedCredit")]
                    [Validation(Required=false)]
                    public long? UsedCredit { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cp-inst-001</para>
                /// </summary>
                [NameInMap("CurrentInstanceId")]
                [Validation(Required=false)]
                public string CurrentInstanceId { get; set; }

                [NameInMap("CurrentRemainCredit")]
                [Validation(Required=false)]
                public long? CurrentRemainCredit { get; set; }

                [NameInMap("CurrentTotalCredit")]
                [Validation(Required=false)]
                public long? CurrentTotalCredit { get; set; }

                [NameInMap("CurrentUsedCredit")]
                [Validation(Required=false)]
                public long? CurrentUsedCredit { get; set; }

                [NameInMap("DayUsedCredit")]
                [Validation(Required=false)]
                public long? DayUsedCredit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("PeriodTotalCredit")]
                [Validation(Required=false)]
                public long? PeriodTotalCredit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("PeriodUsedCredit")]
                [Validation(Required=false)]
                public long? PeriodUsedCredit { get; set; }

                [NameInMap("RemainCredit")]
                [Validation(Required=false)]
                public long? RemainCredit { get; set; }

                [NameInMap("TotalCredit")]
                [Validation(Required=false)]
                public long? TotalCredit { get; set; }

                [NameInMap("TotalUsedCredit")]
                [Validation(Required=false)]
                public long? TotalUsedCredit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("WarnPercent")]
                [Validation(Required=false)]
                public int? WarnPercent { get; set; }

                [NameInMap("WeekUsedCredit")]
                [Validation(Required=false)]
                public long? WeekUsedCredit { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent-abc</para>
            /// </summary>
            [NameInMap("UsageInfoKey")]
            [Validation(Required=false)]
            public string UsageInfoKey { get; set; }

        }

    }

}
