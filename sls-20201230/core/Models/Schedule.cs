// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Schedule : TeaModel {
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        [NameInMap("delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        [NameInMap("runImmediately")]
        [Validation(Required=false)]
        public bool? RunImmediately { get; set; }

        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
