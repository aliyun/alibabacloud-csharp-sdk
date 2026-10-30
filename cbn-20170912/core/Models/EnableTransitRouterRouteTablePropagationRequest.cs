// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class EnableTransitRouterRouteTablePropagationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request, including permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request and creates the route learning relationship after the request passes the check.</description></item>
        /// <item><description><b>true</b>: sends a check request. Only the check is performed, and the route learning relationship is not created. The check items include whether required parameters are specified and whether the request format is valid. If the request fails the check, an error message is returned. If the request passes the check, the DryRunOperation error code is returned.</description></item>
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
        /// <para>The ID of the network instance connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

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

    }

}
