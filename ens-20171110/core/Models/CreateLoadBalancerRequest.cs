// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
