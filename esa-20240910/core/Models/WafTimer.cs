// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafTimer : TeaModel {
        [NameInMap("Periods")]
        [Validation(Required=false)]
        public List<WafTimerPeriods> Periods { get; set; }
        public class WafTimerPeriods : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01T01:00:00Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("Scopes")]
        [Validation(Required=false)]
        public string Scopes { get; set; }

        [NameInMap("WeeklyPeriods")]
        [Validation(Required=false)]
        public List<WafTimerWeeklyPeriods> WeeklyPeriods { get; set; }
        public class WafTimerWeeklyPeriods : TeaModel {
            [NameInMap("DailyPeriods")]
            [Validation(Required=false)]
            public List<WafTimerWeeklyPeriodsDailyPeriods> DailyPeriods { get; set; }
            public class WafTimerWeeklyPeriodsDailyPeriods : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>01:00:00</para>
                /// </summary>
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public string Days { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public int? Zone { get; set; }

    }

}
