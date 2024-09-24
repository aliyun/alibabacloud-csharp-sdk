// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// The ID of the OS image that is used by the nodes.
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The Kubernetes version that is used by the nodes. You can call the [DescribeKubernetesVersionMetadata](https://help.aliyun.com/document_detail/2667899.html) operation to query the Kubernetes version of the cluster returned in the current_version parameter.
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// The nodes that you want to update. If you do not specify this parameter, all nodes in the node pool are updated by default.
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// The rotation configuration.
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public UpgradeClusterNodepoolRequestRollingPolicy RollingPolicy { get; set; }
        public class UpgradeClusterNodepoolRequestRollingPolicy : TeaModel {
            /// <summary>
            /// The update interval between batches takes effect only when the pause policy is set to NotPause. Unit: minutes. Valid values: 5 to 120.
            /// </summary>
            [NameInMap("batch_interval")]
            [Validation(Required=false)]
            public int? BatchInterval { get; set; }

            /// <summary>
            /// The maximum number of unavailable nodes.
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public int? MaxParallelism { get; set; }

            /// <summary>
            /// The policy that is used to pause the update. Valid values:
            /// 
            /// *   FirstBatch: pauses the update after the first batch is completed.
            /// *   EveryBatch: pauses after each batch is completed.
            /// *   NotPause: does not pause.
            /// </summary>
            [NameInMap("pause_policy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// The runtime type. You can call the [DescribeKubernetesVersionMetadata](https://help.aliyun.com/document_detail/2667899.html) operation to query the runtime information returned in the runtime parameter.
        /// </summary>
        [NameInMap("runtime_type")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        /// <summary>
        /// The version of the container runtime that is used by the nodes. You can call the [DescribeKubernetesVersionMetadata](https://help.aliyun.com/document_detail/2667899.html) operation to query the runtime version information returned in the runtime parameter.
        /// </summary>
        [NameInMap("runtime_version")]
        [Validation(Required=false)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Specifies whether to perform the update by replacing the system disk. Valid values:
        /// 
        /// *   true: updates by replacing the system disk.
        /// *   false: does not update by replacing the system disk.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("use_replace")]
        [Validation(Required=false)]
        public bool? UseReplace { get; set; }

    }

}
