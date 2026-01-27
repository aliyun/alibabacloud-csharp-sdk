// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ExecutePeriod : TeaModel {
        [NameInMap("EffectDay")]
        [Validation(Required=false)]
        public ExecutePeriodEffectDay EffectDay { get; set; }
        public class ExecutePeriodEffectDay : TeaModel {
            [NameInMap("Friday")]
            [Validation(Required=false)]
            public bool? Friday { get; set; }

            [NameInMap("Monday")]
            [Validation(Required=false)]
            public bool? Monday { get; set; }

            [NameInMap("Saturday")]
            [Validation(Required=false)]
            public bool? Saturday { get; set; }

            [NameInMap("Sunday")]
            [Validation(Required=false)]
            public bool? Sunday { get; set; }

            [NameInMap("Thursday")]
            [Validation(Required=false)]
            public bool? Thursday { get; set; }

            [NameInMap("Tuesday")]
            [Validation(Required=false)]
            public bool? Tuesday { get; set; }

            [NameInMap("Wednesday")]
            [Validation(Required=false)]
            public bool? Wednesday { get; set; }

        }

        [NameInMap("EffectTime")]
        [Validation(Required=false)]
        public ExecutePeriodEffectTime EffectTime { get; set; }
        public class ExecutePeriodEffectTime : TeaModel {
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("ScheduleEffect")]
        [Validation(Required=false)]
        public ExecutePeriodScheduleEffect ScheduleEffect { get; set; }
        public class ExecutePeriodScheduleEffect : TeaModel {
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=false)]
            public long? Interval { get; set; }

        }

        [NameInMap("ValidType")]
        [Validation(Required=false)]
        public string ValidType { get; set; }

    }

}
