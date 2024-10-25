// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class StartLoadBalancerListenerRequest : TeaModel {
        /// <summary>
        /// <para>The listener port to be enabled. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The frontend protocol that is used by the ELB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tcp</description></item>
        /// <item><description>udp</description></item>
        /// <item><description>http</description></item>
        /// <item><description>https</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if the same port is used by listeners that use different protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the ELB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5saivuir6b1mupxjfbhmk****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

    }

}
