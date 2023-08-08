// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateAutoscalingConfigRequest : TeaModel {
        [NameInMap("cool_down_duration")]
        [Validation(Required=false)]
        public string CoolDownDuration { get; set; }

        [NameInMap("daemonset_eviction_for_nodes")]
        [Validation(Required=false)]
        public bool? DaemonsetEvictionForNodes { get; set; }

        [NameInMap("expander")]
        [Validation(Required=false)]
        public string Expander { get; set; }

        [NameInMap("gpu_utilization_threshold")]
        [Validation(Required=false)]
        public string GpuUtilizationThreshold { get; set; }

        [NameInMap("max_graceful_termination_sec")]
        [Validation(Required=false)]
        public int? MaxGracefulTerminationSec { get; set; }

        [NameInMap("min_replica_count")]
        [Validation(Required=false)]
        public int? MinReplicaCount { get; set; }

        [NameInMap("recycle_node_deletion_enabled")]
        [Validation(Required=false)]
        public bool? RecycleNodeDeletionEnabled { get; set; }

        [NameInMap("scale_down_enabled")]
        [Validation(Required=false)]
        public bool? ScaleDownEnabled { get; set; }

        [NameInMap("scale_up_from_zero")]
        [Validation(Required=false)]
        public bool? ScaleUpFromZero { get; set; }

        [NameInMap("scan_interval")]
        [Validation(Required=false)]
        public string ScanInterval { get; set; }

        [NameInMap("skip_nodes_with_local_storage")]
        [Validation(Required=false)]
        public bool? SkipNodesWithLocalStorage { get; set; }

        [NameInMap("skip_nodes_with_system_pods")]
        [Validation(Required=false)]
        public bool? SkipNodesWithSystemPods { get; set; }

        [NameInMap("unneeded_duration")]
        [Validation(Required=false)]
        public string UnneededDuration { get; set; }

        [NameInMap("utilization_threshold")]
        [Validation(Required=false)]
        public string UtilizationThreshold { get; set; }

    }

}
