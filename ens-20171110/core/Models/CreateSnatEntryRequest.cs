// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateSnatEntryRequest : TeaModel {
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the Network Address Translation (NAT) gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5tawjw5j7sgd2deujxuk0****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The name of the SNAT entry. The name must be 1 to 128 characters in length. The name cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <para>The elastic IP address (EIP) in the SNAT entry. Separate multiple EIPs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.XXX.XXX.71</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

        /// <summary>
        /// <para>The CIDR block. You can specify the CIDR block of a network, a vSwitch, or an instance. You can also specify a custom CIDR block. All instances within the CIDR block can access the Internet or external networks by using SNAT.</para>
        /// <remarks>
        /// <para> If you specify <b>SourceVSwitchId</b> and <b>SourceCIDR</b>, <b>SourceVSwitchId</b> does not take effect. The value that you specified for <b>SourceCIDR</b> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("SourceCIDR")]
        [Validation(Required=false)]
        public string SourceCIDR { get; set; }

        /// <summary>
        /// <para>The ID of the network. This parameter specifies that all ENS instances in the network can use the SNAT entry to access the Internet.</para>
        /// <remarks>
        /// <para> If you specify <b>SourceNetworkId</b> and <b>SourceVSwitchId</b> or <b>SourceCIDR</b>, <b>SourceNetworkId</b> does not take effect. The value that you specified for <b>SourceCIDR</b> takes precedence. Priority: <b>SourceCIDR</b> &gt; <b>SourceVSwitchId</b> &gt; <b>SourceNetworkId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>n-2zeuphj08tt7q3brd****</para>
        /// </summary>
        [NameInMap("SourceNetworkId")]
        [Validation(Required=false)]
        public string SourceNetworkId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that you need to access over the Internet. This parameter specifies that Edge Node Service (ENS) instances in the vSwitch can use the SNAT entry to access the Internet.</para>
        /// <remarks>
        /// <para> If you specify <b>SourceVSwitchId</b> and <b>SourceCIDR</b>, <b>SourceVSwitchId</b> does not take effect. The value that you specified for <b>SourceCIDR</b> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1hwx7gi495q260p****</para>
        /// </summary>
        [NameInMap("SourceVSwitchId")]
        [Validation(Required=false)]
        public string SourceVSwitchId { get; set; }

        /// <summary>
        /// <para>The secondary EIP in the SNAT entry. Separate multiple secondary EIPs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>101.XXX.XXX.7</para>
        /// </summary>
        [NameInMap("StandbySnatIp")]
        [Validation(Required=false)]
        public string StandbySnatIp { get; set; }

    }

}
