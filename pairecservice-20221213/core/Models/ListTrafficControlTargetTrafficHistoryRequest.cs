// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTrafficControlTargetTrafficHistoryRequest : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("ExperimentGroupId")]
        [Validation(Required=false)]
        public string ExperimentGroupId { get; set; }

        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public string ExperimentId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public string Threshold { get; set; }

    }

}
