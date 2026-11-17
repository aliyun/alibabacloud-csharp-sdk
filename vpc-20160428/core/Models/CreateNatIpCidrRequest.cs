// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpCidrRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the NAT CIDR block. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC NAT gateway to which the NAT CIDR block belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-gw8v16wgvtq26vh59****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// <para>The NAT CIDR block to be created. The new CIDR block must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>It must belong to the 10.0.0.0/8, 172.16.0.0/12, or 192.168.0.0/16 CIDR block or their subnets.</description></item>
        /// <item><description>The subnet mask must be 16 to 32 bits in length.</description></item>
        /// <item><description>It cannot overlap with the private CIDR block of the VPC to which the VPC NAT gateway belongs. If you need to transform private IP addresses to other addresses within the private CIDR block of the VPC, create a vSwitch in the corresponding private CIDR block of the VPC, and then create a new VPC NAT gateway in the vSwitch to provide private IP address translation services.</description></item>
        /// <item><description>If you want to use a public CIDR block as the NAT CIDR block, the CIDR block must belong to the user CIDR block of the VPC to which the VPC NAT gateway belongs. For more information about user CIDR blocks, see <a href="https://help.aliyun.com/document_detail/185311.html">What is a user CIDR block?</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("NatIpCidr")]
        [Validation(Required=false)]
        public string NatIpCidr { get; set; }

        /// <summary>
        /// <para>The description of the NAT CIDR block. The description must be 2 to 256 characters in length, and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mycidr</para>
        /// </summary>
        [NameInMap("NatIpCidrDescription")]
        [Validation(Required=false)]
        public string NatIpCidrDescription { get; set; }

        /// <summary>
        /// <para>The name of the NAT CIDR block. The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newcidr</para>
        /// </summary>
        [NameInMap("NatIpCidrName")]
        [Validation(Required=false)]
        public string NatIpCidrName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway to which the NAT CIDR block to be created belongs. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eu-central-1</para>
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
