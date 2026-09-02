// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafTimer : TeaModel {
        /// <summary>
        /// <para>The effective periods.</para>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<WafTimerPeriods> Periods { get; set; }
        public class WafTimerPeriods : TeaModel {
            /// <summary>
            /// <para>The end time in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time in RFC 3339 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The timer type: permanently effective (permanent/empty), effective during time periods (periods), or periodically effective (weekly).</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// <para>The weekly effective periods.</para>
        /// </summary>
        [NameInMap("WeeklyPeriods")]
        [Validation(Required=false)]
        public List<WafTimerWeeklyPeriods> WeeklyPeriods { get; set; }
        public class WafTimerWeeklyPeriods : TeaModel {
            /// <summary>
            /// <para>The effective period within the epoch.</para>
            /// </summary>
            [NameInMap("DailyPeriods")]
            [Validation(Required=false)]
            public List<WafTimerWeeklyPeriodsDailyPeriods> DailyPeriods { get; set; }
            public class WafTimerWeeklyPeriodsDailyPeriods : TeaModel {
                /// <summary>
                /// <para>The end time in HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>The start time in HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>The days of the week, separated by commas. Values 1-7 represent Monday through Sunday.<br>Example: Monday and Wednesday is &quot;1,3&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public string Days { get; set; }

        }

        /// <summary>
        /// <para>The time zone. Default value: UTC+00:00.<br>Example: 8 indicates UTC+8, -8 indicates UTC-8.<br>Valid range: -12 to +14.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public int? Zone { get; set; }

    }

}
