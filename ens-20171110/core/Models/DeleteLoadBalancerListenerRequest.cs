// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteLoadBalancerListenerRequest : TeaModel {
        /// <summary>
        /// The frontend port that is used by the Edge Load Balance (ELB) instance. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The frontend protocol that is used by the ELB instance.
        /// 
        /// >  This parameter is required if the same port is used by listeners that use different protocols.
        /// 
        /// Valid values:
        /// 
        /// *   tcp
        /// *   udp
        /// *   http
        /// *   https
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
