// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class UpdateTransitRouterRouteTableRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Default values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): performs a dry run and sends the request.</description></item>
        /// <item><description><b>true</b>: performs a dry run. The system checks the required parameters and the request syntax. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
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
        /// <para>The features of the route table.</para>
        /// </summary>
        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public UpdateTransitRouterRouteTableRequestRouteTableOptions RouteTableOptions { get; set; }
        public class UpdateTransitRouterRouteTableRequestRouteTableOptions : TeaModel {
            /// <summary>
            /// <para>Indicates whether multi-region ECMP routing is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disable</b>: If multi-region ECMP routing is disabled, routes that are learned from different regions but have the same prefix and attributes select the transit router with the smallest region ID as the next hop. Region IDs are sorted in alphabetic order. The network latency and bandwidth consumption also vary based on the region. Proceed with caution.</description></item>
            /// <item><description><b>enable</b>: If multi-region ECMP routing is enabled, routes that are learned from different regions but have the same prefix and attributes form an ECMP route. The network latency and bandwidth consumption also vary based on the region. Proceed with caution.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disable</para>
            /// </summary>
            [NameInMap("MultiRegionECMP")]
            [Validation(Required=false)]
            public string MultiRegionECMP { get; set; }

        }

        /// <summary>
        /// <para>The description of the route table.</para>
        /// <para>The description must be 1 to 256 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdesc</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableDescription")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableDescription { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1dudbh2d5na6b50****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// <para>The name of the route table.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with http:// or https://. You can also leave this parameter empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testname</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableName")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableName { get; set; }

    }

}
