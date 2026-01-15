// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetNatIpCidrAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the VPC NAT gateway instance to which the queried NAT IP address range belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8v16wgvtq26vh59****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The queried NAT IP address range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// <para>Description of the queried NAT IP address range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("NatIpCidrDescription")]
        [Validation(Required=false)]
        public string NatIpCidrDescription { get; set; }

        /// <summary>
        /// <para>The instance ID of the queried NAT IP address range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatcidr-gw8lhqtvdn4qnea****</para>
        /// </summary>
        [NameInMap("NatIpCidrId")]
        [Validation(Required=false)]
        public string NatIpCidrId { get; set; }

        /// <summary>
        /// <para>The name of the queried NAT IP address range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("NatIpCidrName")]
        [Validation(Required=false)]
        public string NatIpCidrName { get; set; }

        /// <summary>
        /// <para>The status of the queried NAT IP address segment. Values:</para>
        /// <list type="bullet">
        /// <item><description>Available: Available status.</description></item>
        /// <item><description>Deleting: In the process of being deleted.</description></item>
        /// <item><description>Creating: In the process of being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("NatIpCidrStatus")]
        [Validation(Required=false)]
        public string NatIpCidrStatus { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9AD97A0-5338-43F8-8A80-5E274CCBA11B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
