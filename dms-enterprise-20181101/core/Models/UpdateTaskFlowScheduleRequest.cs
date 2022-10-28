// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateTaskFlowScheduleRequest : TeaModel {
        [NameInMap("CronBeginDate")]
        [Validation(Required=false)]
        public string CronBeginDate { get; set; }

        [NameInMap("CronEndDate")]
        [Validation(Required=false)]
        public string CronEndDate { get; set; }

        [NameInMap("CronStr")]
        [Validation(Required=false)]
        public string CronStr { get; set; }

        [NameInMap("CronType")]
        [Validation(Required=false)]
        public string CronType { get; set; }

        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        [NameInMap("ScheduleParam")]
        [Validation(Required=false)]
        public string ScheduleParam { get; set; }

        [NameInMap("ScheduleSwitch")]
        [Validation(Required=false)]
        public bool? ScheduleSwitch { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("TimeZoneId")]
        [Validation(Required=false)]
        public string TimeZoneId { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
