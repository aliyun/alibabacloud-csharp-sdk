// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroupParam : TeaModel {
        [NameInMap("AutoPayOrder")]
        [Validation(Required=false)]
        public bool? AutoPayOrder { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DiskInfo> DataDisks { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        [NameInMap("NodeGroupIndex")]
        [Validation(Required=false)]
        public int? NodeGroupIndex { get; set; }

        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        [NameInMap("PaymentDuration")]
        [Validation(Required=false)]
        public int? PaymentDuration { get; set; }

        [NameInMap("PaymentDurationUnit")]
        [Validation(Required=false)]
        public string PaymentDurationUnit { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDiskParam SystemDisk { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
