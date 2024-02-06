// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class AddBackendServersShrinkRequest : TeaModel {
        /// <summary>
        /// The list of backend servers that you want to add. You can add at most 20 backend servers.
        /// 
        /// >  Only ENS instances that are in the running state can be attached to the ELB instance as backend servers.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public string BackendServersShrink { get; set; }

        /// <summary>
        /// The frontend port that is used by the Edge Load Balance (ELB) instance. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
