// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you want to add. You can add at most 20 backend servers.</para>
        /// <remarks>
        /// <para> Only ENS instances that are in the running state can be attached to the ELB instance as backend servers.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServersShrink { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the Edge Load Balance (ELB) instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5qzdmxefgrpxd7oz2mefonvtx</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
