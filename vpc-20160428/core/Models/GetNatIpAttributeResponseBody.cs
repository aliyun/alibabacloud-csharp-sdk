// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatIpAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time of the queried NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-16T16:47Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The ID of the VPC NAT gateway instance to which the queried NAT IP address belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8v16wgvtq26vh59****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The queried NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.34</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The address range where the queried NAT IP address is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// <para>Description of the queried NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("NatIpDescription")]
        [Validation(Required=false)]
        public string NatIpDescription { get; set; }

        /// <summary>
        /// <para>The ID of the queried NAT IP address instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8y7q3cpk3fggs87****</para>
        /// </summary>
        [NameInMap("NatIpId")]
        [Validation(Required=false)]
        public string NatIpId { get; set; }

        /// <summary>
        /// <para>Name of the queried NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("NatIpName")]
        [Validation(Required=false)]
        public string NatIpName { get; set; }

        /// <summary>
        /// <para>The status of the queried NAT IP address. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Available</b>: Available.</description></item>
        /// <item><description><b>Deleting</b>: Deleting.</description></item>
        /// <item><description><b>Creating</b>: Creating.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("NatIpStatus")]
        [Validation(Required=false)]
        public string NatIpStatus { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D55DB90-0D57-46AB-841D-1D4238514AC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
