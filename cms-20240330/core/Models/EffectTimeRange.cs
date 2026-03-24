// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class EffectTimeRange : TeaModel {
        [NameInMap("dayInWeek")]
        [Validation(Required=false)]
        public List<int?> DayInWeek { get; set; }

        [NameInMap("endTimeInMinute")]
        [Validation(Required=false)]
        public int? EndTimeInMinute { get; set; }

        [NameInMap("startTimeInMinute")]
        [Validation(Required=false)]
        public int? StartTimeInMinute { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
