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
        /// <para>This parameter is deprecated. No need to pass values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s</para>
        /// </summary>
        [NameInMap("component_name")]
        [Validation(Required=false)]
        [Obsolete]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>Specifies whether to upgrade only master nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: upgrades master nodes only.</description></item>
        /// <item><description>false: upgrades both master and worker nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("master_only")]
        [Validation(Required=false)]
        public bool? MasterOnly { get; set; }

        /// <summary>
        /// <para>The target Kubernetes version for cluster upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.16.9-aliyun.1</para>
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
            /// <para>The maximum number of nodes concurrently upgraded per batch.</para>
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
        /// <para>This parameter is deprecated. Use next_version to specify the upgrade target Kubernetes version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.14.8-aliyun.1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        [Obsolete]
        public string Version { get; set; }

    }

}
