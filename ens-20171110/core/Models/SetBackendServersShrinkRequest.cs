// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetBackendServersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of backend servers that you want to add. You can modify at most 20 backend servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServersShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Load Balancer (ELB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5s7crik3yo3bp03gqrbp5****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
