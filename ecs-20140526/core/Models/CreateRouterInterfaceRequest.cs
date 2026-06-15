// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateRouterInterfaceRequest : TeaModel {
        /// <summary>
        /// <para>The access point ID.</para>
        /// </summary>
        [NameInMap("AccessPointId")]
        [Validation(Required=false)]
        public string AccessPointId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values are <c>true</c> and <c>false</c>. The default value is <c>true</c>.</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the router interface. The description must be 2 to 256 characters long, must start with a letter, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The source IP address that is used for the health check.</para>
        /// </summary>
        [NameInMap("HealthCheckSourceIp")]
        [Validation(Required=false)]
        public string HealthCheckSourceIp { get; set; }

        /// <summary>
        /// <para>The destination IP address that is used for the health check.</para>
        /// </summary>
        [NameInMap("HealthCheckTargetIp")]
        [Validation(Required=false)]
        public string HealthCheckTargetIp { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Set the value to <c>PrePaid</c>. This parameter is required if you also specify <c>PricingCycle</c>.</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the router interface. The name must be 2 to 128 characters long and start with a letter. It can contain letters, digits, underscores (_), and hyphens (-).</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the peer access point.</para>
        /// </summary>
        [NameInMap("OppositeAccessPointId")]
        [Validation(Required=false)]
        public string OppositeAccessPointId { get; set; }

        /// <summary>
        /// <para>The ID of the peer router interface.</para>
        /// </summary>
        [NameInMap("OppositeInterfaceId")]
        [Validation(Required=false)]
        public string OppositeInterfaceId { get; set; }

        /// <summary>
        /// <para>The ID of the account to which the peer router interface belongs.</para>
        /// </summary>
        [NameInMap("OppositeInterfaceOwnerId")]
        [Validation(Required=false)]
        public string OppositeInterfaceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the peer region.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OppositeRegionId")]
        [Validation(Required=false)]
        public string OppositeRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the peer router. This parameter is available only when the local and peer router interfaces belong to the same account.</para>
        /// </summary>
        [NameInMap("OppositeRouterId")]
        [Validation(Required=false)]
        public string OppositeRouterId { get; set; }

        /// <summary>
        /// <para>The type of the peer router. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// </list>
        /// <para>Default value: <b>VRouter</b>.</para>
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
        /// <para>The subscription duration. This parameter is required when <c>InstanceChargeType</c> is set to <c>PrePaid</c> and <c>PricingCycle</c> is set to <c>Month</c> or <c>Year</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <c>PricingCycle</c> is set to <c>Month</c>, the valid values are 1 to 9.</description></item>
        /// <item><description>If <c>PricingCycle</c> is set to <c>Year</c>, the valid values are 1 to 3.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle. This parameter is required if <c>InstanceChargeType</c> is set to <c>PrePaid</c>. Valid values are <c>Month</c> and <c>Year</c>.</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>The role of the router interface in the peering connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>InitiatingSide</b>: The router interface is the initiator.</description></item>
        /// <item><description><b>AcceptingSide</b>: The router interface is the acceptor.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The router ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouterId")]
        [Validation(Required=false)]
        public string RouterId { get; set; }

        /// <summary>
        /// <para>The router type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VRouter</b></description></item>
        /// <item><description><b>VBR</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RouterType")]
        [Validation(Required=false)]
        public string RouterType { get; set; }

        /// <summary>
        /// <para>The specification of the router interface. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Mini.2</b></description></item>
        /// <item><description><b>Mini.5</b></description></item>
        /// <item><description><b>Small.1</b></description></item>
        /// <item><description><b>Small.2</b></description></item>
        /// <item><description><b>Small.5</b></description></item>
        /// <item><description><b>Middle.1</b></description></item>
        /// <item><description><b>Middle.2</b></description></item>
        /// <item><description><b>Middle.5</b></description></item>
        /// <item><description><b>Large.1</b></description></item>
        /// <item><description><b>Large.2</b></description></item>
        /// <item><description><b>Large.5</b></description></item>
        /// <item><description><b>Xlarge.1</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The CIDR block of the user. This parameter is required when you create a router interface for a virtual border router (VBR) that is in the same region as the Express Connect circuit, or when both <c>RouterType</c> and <c>OppositeRouterType</c> are set to <c>VBR</c>.</para>
        /// </summary>
        [NameInMap("UserCidr")]
        [Validation(Required=false)]
        public string UserCidr { get; set; }

    }

}
