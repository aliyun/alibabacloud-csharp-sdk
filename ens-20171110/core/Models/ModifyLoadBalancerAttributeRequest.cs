// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyLoadBalancerAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the ELB instance. The name must be **2** to **128** characters in length.
        /// 
        /// >  The value cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

    }

}
