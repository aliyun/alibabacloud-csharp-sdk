// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateTrafficControlTargetRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

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

        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

        [NameInMap("new-param-3")]
        [Validation(Required=false)]
        public string NewParam3 { get; set; }

    }

}
