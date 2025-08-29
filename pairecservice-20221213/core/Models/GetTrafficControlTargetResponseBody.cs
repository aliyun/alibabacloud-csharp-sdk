// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTargetResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NewProductRegulation")]
        [Validation(Required=false)]
        public bool? NewProductRegulation { get; set; }

        [NameInMap("RecallName")]
        [Validation(Required=false)]
        public string RecallName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SplitParts")]
        [Validation(Required=false)]
        public GetTrafficControlTargetResponseBodySplitParts SplitParts { get; set; }
        public class GetTrafficControlTargetResponseBodySplitParts : TeaModel {
            [NameInMap("SetPoints")]
            [Validation(Required=false)]
            public List<long?> SetPoints { get; set; }

            [NameInMap("SetValues")]
            [Validation(Required=false)]
            public List<long?> SetValues { get; set; }

            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public List<long?> TimePoints { get; set; }

        }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("StatisPeriod")]
        [Validation(Required=false)]
        public string StatisPeriod { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("ToleranceValue")]
        [Validation(Required=false)]
        public long? ToleranceValue { get; set; }

        [NameInMap("TrafficControlTargetId")]
        [Validation(Required=false)]
        public string TrafficControlTargetId { get; set; }

        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
