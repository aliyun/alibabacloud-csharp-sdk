// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StartLoadBalancerListenerRequest : TeaModel {
        /// <summary>
        /// The frontend port that is used by the Edge Load Balance (ELB) instance. Valid values: **1** to **65535**.
        /// 
        /// > 
        /// 
        /// *   You cannot specify port 250, 4789, or 4790 for UDP listeners. The preceding ports are system reserved ports.
        /// 
        /// *   We recommend that you use port 80 for HTTP.
        /// 
        /// *   We recommend that you use port 443 for HTTPS.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The frontend protocol that is used by the ELB instance. Valid values:
        /// 
        /// *   tcp
        /// *   udp
        /// *   http
        /// *   https
        /// 
        /// >  This parameter is required if the same port is used by listeners that use different protocols.
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ID of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
