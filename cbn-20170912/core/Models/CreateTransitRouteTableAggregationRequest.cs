// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateTransitRouteTableAggregationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>Specifies whether to perform a dry run. The dry run checks items such as permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request and directly creates the aggregate route after the request passes the check.</description></item>
        /// <item><description><b>true</b>: sends a check request without creating the aggregate route. The check items include required parameters and request format. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
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
        /// <item><description>CIDR blocks that start with &quot;0&quot; or &quot;100.64&quot;</description></item>
        /// <item><description>Multicast addresses (224.0.0.1 to 239.255.255.254)</description></item>
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
        /// <para>The description can be empty or 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationDescription")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationDescription { get; set; }

        /// <summary>
        /// <para>The name of the aggregate route.</para>
        /// <para>The name can be empty or 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationName")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationName { get; set; }

        /// <summary>
        /// <para>The propagation scope of the aggregate route.</para>
        /// <para>Set the value to <b>VPC</b>, which indicates that the aggregate route is propagated to all VPC-connected instances that have established an associated forwarding relationship with the current Enterprise Edition transit router route table and have the route synchronization feature enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScope")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationScope { get; set; }

        /// <summary>
        /// <para>The propagation scope list of the aggregate route.</para>
        /// <remarks>
        /// <para>You must specify at least one of the propagation scope and the propagation scope list. We recommend that you use the propagation scope list. The elements in the propagation scope list cannot duplicate the value of the propagation scope.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScopeList")]
        [Validation(Required=false)]
        public List<string> TransitRouteTableAggregationScopeList { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Edition transit router route table.</para>
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
