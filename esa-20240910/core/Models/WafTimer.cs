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
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

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
                [NameInMap("End")]
                [Validation(Required=false)]
                public string End { get; set; }

                [NameInMap("Start")]
                [Validation(Required=false)]
                public string Start { get; set; }

            }

            [NameInMap("Days")]
            [Validation(Required=false)]
            public string Days { get; set; }

        }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public int? Zone { get; set; }

    }

}
