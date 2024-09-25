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
        /// <item><description><para><b>true</b> If you set the value to <b>true</b>:</para>
        /// <list type="bullet">
        /// <item><description>If the NAT gateway has SNAT entries, the system automatically deletes them.</description></item>
        /// <item><description>If the NAT gateway has DNAT entries, the system automatically deletes them.</description></item>
        /// <item><description>If the NAT gateway is associated with an elastic IP address (EIP), the system automatically disassociates the EIP from the NAT gateway.</description></item>
        /// <item><description>If the NAT gateway is associated with a NAT bandwidth plan, the system automatically disassociates the NAT bandwidth plan.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>false</b>(default): no If you set the value to <b>false</b>:</para>
        /// <list type="bullet">
        /// <item><description>If the NAT gateway is associated with a NAT bandwidth plan, disassociate the NAT bandwidth plan first.</description></item>
        /// <item><description>If the NAT gateway has SNAT entries, delete them first.</description></item>
        /// <item><description>If the NAT gateway has DNAT entries, delete them first.</description></item>
        /// <item><description>If the NAT gateway is associated with an EIP, disassociate the EIP from the NAT gateway first.</description></item>
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
        /// <para>The ID of the NAT gateway that you want to delete.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
