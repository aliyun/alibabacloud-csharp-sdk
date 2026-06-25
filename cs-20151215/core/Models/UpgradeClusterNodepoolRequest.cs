// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterNodepoolRequest : TeaModel {
        [NameInMap("ignore_warning_check")]
        [Validation(Required=false)]
        public bool? IgnoreWarningCheck { get; set; }

        /// <summary>
        /// <para>The system image ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_3_x64_20G_container_optimized_20241226.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The Kubernetes version of the node. You can call <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> to obtain the current cluster version information from the <c>KubernetesVersion</c> field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The list of nodes to upgrade. If this parameter is not specified, all nodes in the node pool are upgraded.</para>
        /// </summary>
        [NameInMap("node_names")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        /// <summary>
        /// <para>The rolling update configuration.</para>
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        public UpgradeClusterNodepoolRequestRollingPolicy RollingPolicy { get; set; }
        public class UpgradeClusterNodepoolRequestRollingPolicy : TeaModel {
            /// <summary>
            /// <para>The interval between batches during the upgrade. This parameter takes effect only when the pause policy is set to <c>NotPause</c>.</para>
            /// <para>Valid values: [5,120]. Unit: minutes.</para>
            /// <para>You can set this parameter to 0 to specify no interval between batches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("batch_interval")]
            [Validation(Required=false)]
            public int? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes that can be updated in parallel per batch. Nodes in the node pool are updated in batches.</para>
            /// <para>Valid values: [1,10].</para>
            /// <para>Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public int? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The automatic pause policy during node upgrades. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FirstBatch: pauses after the first batch is complete.</description></item>
            /// <item><description>EveryBatch: pauses after each batch is complete.</description></item>
            /// <item><description>NotPause: does not pause.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NotPause</para>
            /// </summary>
            [NameInMap("pause_policy")]
            [Validation(Required=false)]
            public string PausePolicy { get; set; }

        }

        /// <summary>
        /// <para>The runtime type. You can call <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> to obtain the runtime information from the runtime field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerd</para>
        /// </summary>
        [NameInMap("runtime_type")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        /// <summary>
        /// <para>The runtime version of the node. You can call <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> to obtain the runtime version information from the runtime field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.6.36</para>
        /// </summary>
        [NameInMap("runtime_version")]
        [Validation(Required=false)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use system cloud disk replacement for the upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Uses system cloud disk replacement to upgrade the node pool. ACK reinitializes the nodes based on the current node pool configurations, such as the logon method, labels, taints, operating system image, and runtime version.</description></item>
        /// <item><description>false: Does not use system cloud disk replacement.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("use_replace")]
        [Validation(Required=false)]
        public bool? UseReplace { get; set; }

    }

}
