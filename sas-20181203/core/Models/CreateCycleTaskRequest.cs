// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateCycleTaskRequest : TeaModel {
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        [NameInMap("FirstDateStr")]
        [Validation(Required=false)]
        public long? FirstDateStr { get; set; }

        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("TargetEndTime")]
        [Validation(Required=false)]
        public int? TargetEndTime { get; set; }

        [NameInMap("TargetStartTime")]
        [Validation(Required=false)]
        public int? TargetStartTime { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
