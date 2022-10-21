// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class Node : TeaModel {
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        [NameInMap("AutoRenewDurationUnit")]
        [Validation(Required=false)]
        public string AutoRenewDurationUnit { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("MaintenanceStatus")]
        [Validation(Required=false)]
        public string MaintenanceStatus { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        [NameInMap("NodeState")]
        [Validation(Required=false)]
        public string NodeState { get; set; }

        [NameInMap("PrivateIp")]
        [Validation(Required=false)]
        public string PrivateIp { get; set; }

        [NameInMap("PublicIp")]
        [Validation(Required=false)]
        public string PublicIp { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
