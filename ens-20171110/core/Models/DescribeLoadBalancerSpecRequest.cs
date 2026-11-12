// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerSpecRequest : TeaModel {
        /// <summary>
        /// <para>The specification of the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elb.s2.small</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

    }

}
