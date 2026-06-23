// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class FixNodePoolVulsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow node restarts.</para>
        /// <list type="bullet">
        /// <item><description>true: Node restarts are allowed.</description></item>
        /// <item><description>false: Node restarts are not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("auto_restart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        /// <summary>
        /// <para>The list of node names to fix. If this parameter is not specified, all nodes in the node pool are fixed by default.</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The rolling fix policy.</para>
        /// </summary>
        [NameInMap("rollout_policy")]
        [Validation(Required=false)]
        public FixNodePoolVulsRequestRolloutPolicy RolloutPolicy { get; set; }
        public class FixNodePoolVulsRequestRolloutPolicy : TeaModel {
            /// <summary>
            /// <para>CVE fixes for nodes in the node pool are performed in batches. This parameter specifies the maximum number of nodes that can be fixed in parallel per batch.</para>
            /// <para>Valid values: minimum value is 1 and maximum value is the total number of nodes in the node pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("max_parallelism")]
            [Validation(Required=false)]
            public long? MaxParallelism { get; set; }

        }

        /// <summary>
        /// <para>The list of vulnerabilities.</para>
        /// </summary>
        [NameInMap("vuls")]
        [Validation(Required=false)]
        public List<string> Vuls { get; set; }

    }

}
