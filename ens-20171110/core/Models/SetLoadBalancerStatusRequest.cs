// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ELB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5t18quoohsrc3xkf86spmnu77</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The status of the listener after the modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Active</b>: The listener for the instance can forward the received traffic based on forwarding rules.</description></item>
        /// <item><description><b>InActive</b>: The listener for the instance does not forward the received traffic.</description></item>
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
