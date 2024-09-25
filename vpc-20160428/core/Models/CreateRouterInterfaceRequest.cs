// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouterInterfaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access point to which the VBR belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36062.html">DescribeAccessPoints</a> operation to obtain the IDs of access points.</para>
        /// <remarks>
        /// <para> This parameter is required if the VBR is connected to an Express Connect circuit.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-hangzhou-yh-ts-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): The automatic payment is disabled. If you select this option, you must go to the Order Center to complete the payment after an order is generated.</description></item>
        /// <item><description><b>true</b>: The automatic payment is enabled. Payments are automatically complete after an order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the router interface.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcabc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the VBR that is created in the Fast Link mode is uplinked to the router interface. The Fast Link mode helps automatically connect router interfaces that are created for the VBR and its peer VPC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only if <b>RouterType</b> is set to <b>VBR</b> and <b>OppositeRouterType</b> is set to <b>VRouter</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>FastLinkMode</b> is set to <b>true</b>, <b>Role</b> must be set to <b>InitiatingSide</b>. In this case, <b>AccessPointId</b>, <b>OppositeRouterType</b>, <b>OpppsiteRouterId</b>, and <b>OppositeInterfaceOwnerId</b> are required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public bool? FastLinkMode { get; set; }

        /// <summary>
        /// <para>The source IP address that is used to perform health checks. The source IP address must be an idle IP address of the local virtual private cloud (VPC).</para>
        /// <remarks>
        /// <para> You can set this parameter when an Express Connect circuit is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.6</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address that is used to perform health checks.</para>
        /// <remarks>
        /// <para> This parameter is required if you specify <b>HealthCheckSourceIp</b></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.8</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The billing method of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the router interface.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the access point to which the peer belongs.</para>
        /// <remarks>
        /// <para> This parameter is required if the peer router interface is associated with a VBR. The specified value cannot be changed after the router interface is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-shanghai-nt-aligroup-C</para>
        /// </summary>
        [NameInMap("OppositeAccessPointId")]
        [Validation(Required=false)]
        public string OppositeAccessPointId { get; set; }

        /// <summary>
        /// <para>The ID of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urzd****</para>
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the peer router interface belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>253460731706911258</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the acceptor is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the peer router.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrt-bp1lhl0taikrteen8****</para>
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// <para>The type of router that is associated with the peer router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("OppositeRouterType")]
        [Validation(Required=false)]
        public string OppositeRouterType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid values when PricingCycle is set to Month: <b>1 to 9</b>.</description></item>
        /// <item><description>Valid values when PricingCycle is set to Year: <b>1 to 3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b> (default)</description></item>
        /// <item><description><b>Year</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required if <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the router interface belongs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// <para>For more information about resource group, see <a href="https://help.aliyun.com/document_detail/94475.html">What is Resource Management?</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The role of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>InitiatingSide</b>: requester</description></item>
        /// <item><description><b>AcceptingSide</b>: acceptor</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InitiatingSide</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The ID of the router that is associated with the router interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-m5ebm6g9ptc9mly1c****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The type of router that is associated with the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VRouter</para>
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// <para>The specification of the router interface and the corresponding bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Mini.2</b>: 2 Mbit/s</description></item>
        /// <item><description><b>Mini.5</b>: 5 Mbit/s</description></item>
        /// <item><description><b>Small.1</b>: 10 Mbit/s</description></item>
        /// <item><description><b>Small.2</b>: 20 Mbit/s</description></item>
        /// <item><description><b>Small.5</b>: 50 Mbit/s</description></item>
        /// <item><description><b>Middle.1</b>: 100 Mbit/s</description></item>
        /// <item><description><b>Middle.2</b>: 200 Mbit/s</description></item>
        /// <item><description><b>Middle.5</b>: 500 Mbit/s</description></item>
        /// <item><description><b>Large.1</b>: 1,000 Mbit/s</description></item>
        /// <item><description><b>Large.2</b>: 2,000 Mbit/s</description></item>
        /// <item><description><b>Large.5</b>: 5,000 Mbit/s</description></item>
        /// <item><description><b>Xlarge.1</b>: 10,000 Mbit/s</description></item>
        /// </list>
        /// <remarks>
        /// <para> If <b>Role</b> is set to <b>AcceptingSide</b>, set <b>Spec</b> to <b>Negative</b>. This indicates that you do not need to specify the specification when you create an acceptor router interface.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mini.2</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The tag to add to the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateRouterInterfaceRequestTags> Tags { get; set; }
        public class CreateRouterInterfaceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key to add to the resource. You must enter at least one tag key. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be at most 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value to add to the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
