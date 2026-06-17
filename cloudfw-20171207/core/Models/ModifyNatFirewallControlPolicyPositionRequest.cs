// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyNatFirewallControlPolicyPositionRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66461eea-e659-4225-84c9-*****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The traffic direction of the access control policy.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>out</b>: outbound traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the NAT Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-xxxxxx</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The new priority for the IPv4 access control policy of the NAT firewall.
        /// Priorities are represented by numbers. A smaller number indicates a higher priority. The value 1 indicates the highest priority.</para>
        /// <remarks>
        /// <para>The new priority must be within the range of existing priorities for IPv4 policies of the NAT firewall. Otherwise, the call fails.</para>
        /// </remarks>
        /// <para>Before calling this operation, call the DescribeNatFirewallPolicyPriorUsed operation to query the priority range of existing IPv4 policies for the specified traffic direction of the NAT firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("NewOrder")]
        [Validation(Required=false)]
        public int? NewOrder { get; set; }

    }

}
