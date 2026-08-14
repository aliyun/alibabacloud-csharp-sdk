// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DeleteNatGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully delete the NAT gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: forcefully deletes the NAT gateway. If you set this parameter to <b>true</b>:</para>
        /// <list type="bullet">
        /// <item><description><para>If the NAT gateway has SNAT rules, the system force deletes the SNAT rules.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has DNAT rules, the system force deletes the DNAT rules.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has associated elastic IP addresses (EIPs), the system automatically disassociates the EIPs.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has NAT service plans that are not deleted, the system force deletes the NAT service plans.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): does not forcefully delete the NAT gateway. If you set this parameter to <b>false</b>:</para>
        /// <list type="bullet">
        /// <item><description><para>If the NAT gateway has NAT service plans that are not deleted, delete the NAT service plans first.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has SNAT rules, delete the SNAT rules first.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has DNAT rules, delete the DNAT rules first.</para>
        /// </description></item>
        /// <item><description><para>If the NAT gateway has associated EIPs, disassociate the EIPs first.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The instance ID of the NAT gateway that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-bp1uewa15k4iy5770****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
