// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocatePublicIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the instance to which you want to allocate a public IP address.</para>
        /// <remarks>
        /// <para>The public bandwidth of the instance must be greater than 0.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1gtjxuuvwj17zr****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The public IP address of the instance. If this parameter is left empty, the system randomly assigns an IP address.</para>
        /// <remarks>
        /// <para>Only users in the whitelist can specify this parameter. Regular users cannot specify an IP address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>112.124.**.**</c></para>
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

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
        /// <para>The VLAN ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter will be deprecated. For better compatibility, use other parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>720</para>
        /// </summary>
        [NameInMap("VlanId")]
        [Validation(Required=false)]
        public string VlanId { get; set; }

    }

}
