// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers to add. You can add up to 20 backend servers per invoke.</para>
        /// <remarks>
        /// <para>Backend servers (ENS instances) must be in the Running state before they can be added to a load balancing instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServersShrink { get; set; }

        /// <summary>
        /// <para>The frontend port used by the load balancing instance. Valid values: <b>1</b> to <b>65535</b>.</para>
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
