// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyTransitRouteTableAggregationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>RequestId</b> as the <b>ClientToken</b>. The <b>RequestId</b> may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run to check information such as the permissions and instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends the request. If the request passes the check, an Enterprise Edition transit router is created.</description></item>
        /// <item><description><b>true</b>: checks the request but does not create the Enterprise Edition transit router. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
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
        /// <para>The description can be empty or 0 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationDescription")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationDescription { get; set; }

        /// <summary>
        /// <para>The name of the aggregate route.</para>
        /// <para>The name can be empty or 1 to 128 characters in length, and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationName")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationName { get; set; }

        /// <summary>
        /// <para>The scope of networks that you want to advertise the aggregate route.</para>
        /// <para>The valid value is <b>VPC</b>, which indicates that the aggregate route is advertised to all VPCs that have associated forwarding correlation with the Enterprise Edition transit router and have route synchronization enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScope")]
        [Validation(Required=false)]
        public string TransitRouteTableAggregationScope { get; set; }

        /// <summary>
        /// <para>The scope of networks to which the aggregate route is advertised.</para>
        /// <remarks>
        /// <para> You must select at least one attribute from either the Aggregate Route Propagation Range or the Aggregate Route Propagation Range List. We recommend using the latter. The elements of the two attributes cannot duplicate.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransitRouteTableAggregationScopeList")]
        [Validation(Required=false)]
        public List<string> TransitRouteTableAggregationScopeList { get; set; }

        /// <summary>
        /// <para>The list of route table IDs of the Enterprise Edition transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-6ehgc262hr170qgyc****</para>
        /// </summary>
        [NameInMap("TransitRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouteTableId { get; set; }

    }

}
