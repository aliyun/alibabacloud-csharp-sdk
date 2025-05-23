// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class RunClusterCheckRequest : TeaModel {
        /// <summary>
        /// <para>The cluster check parameters.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The check target.</para>
        /// <para>If you set <c>type=NodePoolUpgrade</c>, you must set this parameter to the node pool ID. Otherwise, this parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np1f6779297c4444a3a1cdd29be8e5****</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The check type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ClusterMigrate: cluster migration.</description></item>
        /// <item><description>MasterUpgrade: control plane upgrade.</description></item>
        /// <item><description>NodePoolUpgrade: node pool upgrade.</description></item>
        /// <item><description>ClusterUpgrade: cluster upgrade.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClusterUpgrade</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
