// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroup : TeaModel {
        [NameInMap("AdditionalSecurityGroupIds")]
        [Validation(Required=false)]
        public List<string> AdditionalSecurityGroupIds { get; set; }

        [NameInMap("CostOptimizedConfig")]
        [Validation(Required=false)]
        public CostOptimizedConfig CostOptimizedConfig { get; set; }

        [NameInMap("DataDisks")]
        [Validation(Required=false)]
        public List<DataDisk> DataDisks { get; set; }

        [NameInMap("DeploymentSetStrategy")]
        [Validation(Required=false)]
        public string DeploymentSetStrategy { get; set; }

        [NameInMap("GracefulShutdown")]
        [Validation(Required=false)]
        public bool? GracefulShutdown { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        [NameInMap("NodeGroupState")]
        [Validation(Required=false)]
        public string NodeGroupState { get; set; }

        [NameInMap("NodeGroupType")]
        [Validation(Required=false)]
        public string NodeGroupType { get; set; }

        [NameInMap("NodeResizeStrategy")]
        [Validation(Required=false)]
        public string NodeResizeStrategy { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("RunningNodeCount")]
        [Validation(Required=false)]
        public int? RunningNodeCount { get; set; }

        [NameInMap("SpotBidPrices")]
        [Validation(Required=false)]
        public List<SpotBidPrice> SpotBidPrices { get; set; }

        [NameInMap("SpotInstanceRemedy")]
        [Validation(Required=false)]
        public bool? SpotInstanceRemedy { get; set; }

        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        [NameInMap("StateChangeReason")]
        [Validation(Required=false)]
        public NodeGroupStateChangeReason StateChangeReason { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        [NameInMap("WithPublicIp")]
        [Validation(Required=false)]
        public bool? WithPublicIp { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
