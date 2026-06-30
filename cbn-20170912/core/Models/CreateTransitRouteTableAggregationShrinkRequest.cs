// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouteTableAggregationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a value from your client to make sure that the value is unique among different requests. The ClientToken can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request. A dry run checks permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, an aggregate route is created.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: sends a check request to verify the required parameters and the request format. The aggregate route is not created. If the request fails the check, an error is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The destination CIDR block of the aggregate route.</para>
        /// <remarks>
        /// <para>The following CIDR blocks are not supported:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>CIDR blocks that start with 0 or 100.64</para>
        /// </description></item>
        /// <item><description><para>Multicast addresses (224.0.0.1 to 239.255.255.254)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationCidr")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationCidr { get; set; }

        /// <summary>
        /// <para>The description of the aggregate route.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationDescription")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationDescription { get; set; }

        /// <summary>
        /// <para>The name of the aggregate route.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationName")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationName { get; set; }

        /// <summary>
        /// <para>The propagation scope of the aggregate route.</para>
        /// <para>The only valid value is <b>VPC</b>. This value indicates that the aggregate route is propagated to all VPC instances that are associated with the route table of the Enterprise Edition transit router and have route synchronization enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScope")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationScope { get; set; }

        /// <summary>
        /// <para>The list of propagation scopes for the aggregate route.</para>
        /// <remarks>
        /// <para>You must specify either this parameter or TransitRouteTableAggregationScope. We recommend that you use this parameter. The elements in this list cannot be the same as the value of TransitRouteTableAggregationScope.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScopeList")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationScopeListShrink { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-iq8qgruq1ry8jc7vt****</para>
        /// </summary>
        [NameInMap("TransitRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouteTableId { get; set; }

    }

}
