// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterChecksRequest : TeaModel {
        /// <summary>
        /// <para>The check target to filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp19ay6nnvd4cexxxx</para>
        /// </summary>
        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The check type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ClusterMigrate: cluster migration.</para>
        /// </description></item>
        /// <item><description><para>MasterUpgrade: cluster control plane upgrade.</para>
        /// </description></item>
        /// <item><description><para>NodePoolUpgrade: node pool upgrade.</para>
        /// </description></item>
        /// <item><description><para>ClusterUpgrade: cluster upgrade.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ClusterUpgrade</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
