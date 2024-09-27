// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class EdgeClusterAddEdgeMachineRequest : TeaModel {
        /// <summary>
        /// <para>The timeout period of sessions. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public long? Expired { get; set; }

        /// <summary>
        /// <para>The node pool ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c26607f52179f4472a0d9723e7595****</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The options that you want to configure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;enableIptables\&quot;:true,\&quot;quiet\&quot;:true,\&quot;manageRuntime\&quot;:true,\&quot;allowedClusterAddons\&quot;:[\&quot;kube-proxy\&quot;,\&quot;flannel\&quot;,\&quot;coredns\&quot;]}&quot;</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public string Options { get; set; }

    }

}
