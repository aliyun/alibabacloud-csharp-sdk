// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterChecksRequest : TeaModel {
        /// <summary>
        /// <para>Filters the specified check objects.</para>
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
        /// <item><description>ClusterMigrate: cluster migration</description></item>
        /// <item><description>MasterUpgrade: cluster control plane upgrade</description></item>
        /// <item><description>NodePoolUpgrade: node pool upgrade</description></item>
        /// <item><description>ClusterUpgrade: cluster upgrade</description></item>
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
