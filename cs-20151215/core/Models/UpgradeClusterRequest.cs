// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpgradeClusterRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Do not specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("component_name")]
        [Validation(Required=false)]
        [Obsolete]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>Specifies whether to upgrade only the control plane. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Upgrades only the control plane.</description></item>
        /// <item><description>false: Upgrades the control plane and worker nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("master_only")]
        [Validation(Required=false)]
        public bool? MasterOnly { get; set; }

        /// <summary>
        /// <para>The target version for the cluster upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("next_version")]
        [Validation(Required=false)]
        public string NextVersion { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The rolling update configuration.</para>
        /// </summary>
        [NameInMap("rolling_policy")]
        [Validation(Required=false)]
        [Obsolete]
        public UpgradeClusterRequestRollingPolicy RollingPolicy { get; set; }
        public class UpgradeClusterRequestRollingPolicy : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The maximum number of worker nodes that can be upgraded in parallel per batch.</para>
            /// <para>During the worker node upgrade process, nodes are upgraded in sequence based on the specified maximum parallelism. The number of nodes upgraded in each batch increases in the sequence of 1, 2, 4, 8, and so on, until the maximum parallelism is reached. After the maximum parallelism is reached, each subsequent batch upgrades the maximum number of nodes in parallel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            [Obsolete]
            public int? MaxParallelism { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the next_version parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        [Obsolete]
        public string Version { get; set; }

    }

}
