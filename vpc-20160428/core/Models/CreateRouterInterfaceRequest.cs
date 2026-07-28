// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateRouterInterfaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access point to which the VBR belongs. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36062.html">DescribeAccessPoints</a> operation to query the access point ID of the Express Connect circuit.  </para>
        /// <remarks>
        /// <para>This parameter is required in Express Connect circuit scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ap-cn-hangzhou-yh-ts-A</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Automatic payment is disabled. After an order is generated, go to the Order Center to complete the payment.   </para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Automatic payment is enabled. The order is automatically paid.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
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
        /// <item><description><b>false</b> (default): Auto-renewal is disabled.</description></item>
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. </para>
        /// <para>The client generates the value of this parameter. Ensure that the value is unique among different requests. </para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the router interface.  </para>
        /// <para>The description must be 2 to 256 characters in length and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcabc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the router interface on the VBR is created in fast link mode. Fast link mode allows the router interfaces on the VBR and VPC to be automatically connected after they are created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes.</description></item>
        /// <item><description><b>false</b> (default): no.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when <b>RouterType</b> is set to <b>VBR</b> and <b>OppositeRouterType</b> is set to <b>VRouter</b>.</description></item>
        /// <item><description>When <b>FastLinkMode</b> is set to <b>true</b>, <b>Role</b> must be set to <b>InitiatingSide</b>, and <b>AccessPointId</b>, <b>OppositeRouterType</b>, <b>OppositeRouterId</b>, and <b>OppositeInterfaceOwnerId</b> are required.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FastLinkMode")]
        [Validation(Required=false)]
        public bool? FastLinkMode { get; set; }

        /// <summary>
        /// <para>The source IP address for health checks. The IP address must be an unused IP address in the local VPC. </para>
        /// <remarks>
        /// <para>You can specify this parameter in Express Connect circuit scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.6</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address for health checks. </para>
        /// <remarks>
        /// <para>This parameter is required when <b>HealthCheckSourceIp</b> is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.8</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The billing method of the router interface. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>PrePaid</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>PostPaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the router interface.  </para>
        /// <para>The name must be 2 to 128 characters in length and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
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
        /// <para>This parameter is required when the peer router interface is on a VBR. This parameter cannot be modified after the router interface is created.</para>
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
        /// <para>The Alibaba Cloud account ID of the owner of the peer router interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>253460731706911258</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the accepter.</para>
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
        /// <para>The type of the router associated with the peer router interface. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>VRouter</b>: vRouter.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: Virtual Border Router.</para>
        /// </description></item>
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
        /// <para>The subscription duration. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>If you select monthly billing, the valid values are <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If you select yearly billing, the valid values are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
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
        /// <item><description><para><b>Month</b> (default): monthly billing.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: yearly billing.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>InstanceChargeType</b> is set to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/2381067.html">What is a resource group?</a>.</para>
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
        /// <para>The role of the router interface. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>InitiatingSide</b>: requester.   </para>
        /// </description></item>
        /// <item><description><para><b>AcceptingSide</b>: accepter.</para>
        /// </description></item>
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
        /// <para>The ID of the router associated with the router interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-m5ebm6g9ptc9mly1c****</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The type of the router associated with the router interface. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>VRouter</b>: vRouter.</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: Virtual Border Router.</para>
        /// </description></item>
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
        /// <para>The specification of the router interface. The available specifications and corresponding bandwidth values are as follows: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Mini.2</b>: 2 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Mini.5</b>: 5 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Small.1</b>: 10 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Small.2</b>: 20 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Small.5</b>: 50 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Middle.1</b>: 100 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Middle.2</b>: 200 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Middle.5</b>: 500 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Large.1</b>: 1000 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Large.2</b>: 2000 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Large.5</b>: 5000 Mbps   </para>
        /// </description></item>
        /// <item><description><para><b>Xlarge.1</b>: 10000 Mbps</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <b>Role</b> is set to <b>AcceptingSide</b> (accepter), set <b>Spec</b> to <b>Negative</b>. No specification is required when you create an accepter router interface.</para>
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
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateRouterInterfaceRequestTags> Tags { get; set; }
        public class CreateRouterInterfaceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You must specify at least 1 and can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
