// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterNodepoolRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the OS image used by the nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun_2_1903_x64_20G_alibase_20200529.vhd</para>
        /// </summary>
        [NameInMap("image_id")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The Kubernetes version used by the nodes. You can call the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> operation and get the Kubernetes version of the current cluster in the current_version field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.22.15-aliyun.1</para>
        /// </summary>
        [NameInMap("kubernetes_version")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The nodes you want to update. If you do not specify this parameter, all nodes in the node pool are updated by default.</para>
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
            /// <para>The update interval between batches takes effect only when the pause policy is set to NotPause. Unit: minutes. Valid values: 5 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5 minutes</para>
            /// </summary>
            [NameInMap("batch_interval")]
            [Validation(Required=false)]
            public int? BatchInterval { get; set; }

            /// <summary>
            /// <para>The maximum number of nodes per batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public int? MaxParallelism { get; set; }

            /// <summary>
            /// <para>The policy used to pause the update. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FirstBatch: pauses after the first batch is updated.</description></item>
            /// <item><description>EveryBatch: pauses after each batch is updated.</description></item>
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
        /// <para>The runtime type. You can call the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> operation and get the runtime information in the runtime field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerd</para>
        /// </summary>
        [NameInMap("runtime_type")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        /// <summary>
        /// <para>The version of the container runtime used by the nodes. You can call the <a href="https://help.aliyun.com/document_detail/2667899.html">DescribeKubernetesVersionMetadata</a> operation and get the runtime version in the runtime field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.5.10</para>
        /// </summary>
        [NameInMap("runtime_version")]
        [Validation(Required=false)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform the update by replacing the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: replaces the system disk.</description></item>
        /// <item><description>false: does not replace the system disk.</description></item>
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
