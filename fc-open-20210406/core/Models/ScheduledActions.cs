// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ScheduledActions : TeaModel {
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("scheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public long? Target { get; set; }

    }

}
