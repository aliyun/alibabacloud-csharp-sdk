// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ActivateRouterInterfaceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the router interface.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
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

        /// <summary>
        /// <para>The ID of the router interface. </para>
        /// <remarks>
        /// <para>The ID of the router interface. This operation supports only interfaces in the Inactive state. If the state does not match, the IncorrectRIStatus error is returned. Newly created interfaces are not in the Inactive state and cannot be directly activated: interfaces created in express connect mode are automatically connected and in the Active state. You must first call DeactivateRouterInterface to change them to the Inactive state. Interfaces created in non-express connect mode are in the Idle state. You must first configure peer information and call ConnectRouterInterface to establish the connection to the Active state, and then call DeactivateRouterInterface. State transition: Active --DeactivateRouterInterface--&gt; Inactive --ActivateRouterInterface--&gt; Active. If the interface is in an intermediate state such as Connecting, Activating, or Deactivating, poll DescribeRouterInterfaceAttribute until the state stabilizes.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ri-2zeo3xzyf38r4urz****</para>
        /// </summary>
        [NameInMap("RouterInterfaceId")]
        [Validation(Required=false)]
        public string RouterInterfaceId { get; set; }

    }

}
