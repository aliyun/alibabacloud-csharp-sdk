// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteNatGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully delete the VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// <para>You can forcefully delete a VPC in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Only an IPv4 gateway and routes that point to the IPv4 gateway exist in the VPC.</description></item>
        /// <item><description>Only an IPv6 gateway and routes that point to the IPv6 gateway exist in the VPC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceDelete")]
        [Validation(Required=false)]
        public bool? ForceDelete { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat-5t7nh1cfm6kxiszlttr38****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

    }

}
