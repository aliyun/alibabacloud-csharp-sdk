// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpnGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MYVPN</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;If you did not enable automatic payment for the VPN gateway bill, go to <a href="https://usercenter2.aliyun.com/home">Expenses and Costs</a> to complete the payment.
        /// &lt;props=&quot;intl&quot;&gt;If you did not enable automatic payment for the VPN gateway bill, go to <a href="https://usercenter2-intl.aliyun.com/billing/#/account/overview">Expenses and Costs</a> to complete the payment..</para>
        /// 
        /// <b>Example:</b>
        /// <para>208240895400460</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EB2C156A-41F8-49CC-A756-D55AFC8BFD69</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPN gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpn-uf68lxhgr7ftbqr3p****</para>
        /// </summary>
        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
