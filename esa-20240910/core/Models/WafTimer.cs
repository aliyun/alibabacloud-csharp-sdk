// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafTimer : TeaModel {
        /// <summary>
        /// <para>生效时间段。</para>
        /// </summary>
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<WafTimerPeriods> Periods { get; set; }
        public class WafTimerPeriods : TeaModel {
            /// <summary>
            /// <para>结束时间，值为RFC3339格式的UTC时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>起始时间，值为RFC3339格式的UTC时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>定时类型：永久生效（permanent/&lt;空&gt;）/时间段生效（periods）/weekly（周期生效）。</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// <para>每周生效时间段。</para>
        /// </summary>
        [NameInMap("WeeklyPeriods")]
        [Validation(Required=false)]
        public List<WafTimerWeeklyPeriods> WeeklyPeriods { get; set; }
        public class WafTimerWeeklyPeriods : TeaModel {
            /// <summary>
            /// <para>该周期内的生效时间。</para>
            /// </summary>
            [NameInMap("DailyPeriods")]
            [Validation(Required=false)]
            public List<WafTimerWeeklyPeriodsDailyPeriods> DailyPeriods { get; set; }
            public class WafTimerWeeklyPeriodsDailyPeriods : TeaModel {
                /// <summary>
                /// <para>结束时间，格式为HH:mm:ss。</para>
                /// 
                /// <b>Example:</b>
                /// <para>01:00:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <para>起始时间，格式为HH:mm:ss。</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <para>周期，多个使用逗号分隔，1-7分别代表周一-周日。<br>例：周一，周三值为&quot;1,3&quot;。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public string Days { get; set; }

        }

        /// <summary>
        /// <para>时区，不填则默认为UTC+00:00。<br>例：8表示东8区，-8表示西8区<br>范围：-12 - +14。</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public int? Zone { get; set; }

    }

}
