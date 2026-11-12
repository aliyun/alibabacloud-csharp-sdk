// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerStatusRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5t18quoohsrc3xkf86sp*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The updated instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: Runs the load balancing instance. Listeners in the instance can forward accepted traffic based on rules.</description></item>
        /// <item><description><b>InActive</b>: Stops the load balancing instance. Listeners in the instance no longer forward accepted traffic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

    }

}
