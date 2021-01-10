// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateTSTopologyRequest : TeaModel {
        [NameInMap("BaseVersion")]
        [Validation(Required=false)]
        public long? BaseVersion { get; set; }

        [NameInMap("Cron")]
        [Validation(Required=false)]
        public string Cron { get; set; }

        [NameInMap("CustomParams")]
        [Validation(Required=false)]
        public string CustomParams { get; set; }

        [NameInMap("Des")]
        [Validation(Required=false)]
        public string Des { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IsCrossZoneTopo")]
        [Validation(Required=false)]
        public bool? IsCrossZoneTopo { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public long? ProcessId { get; set; }

        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        [NameInMap("TriggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

    }

}
