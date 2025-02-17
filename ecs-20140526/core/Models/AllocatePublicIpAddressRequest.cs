// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class AllocatePublicIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance to which you want to assign a public IP address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1gtjxuuvwj17zr****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The static public IP address that you want to assign to the instance. This parameter is empty by default, which indicates that a static public IP address is randomly assigned by the system.</para>
        /// <remarks>
        /// <para> Only users in the whitelist can specify this parameter.</para>
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
        /// <para>The virtual LAN (VLAN) ID of the instance.</para>
        /// <remarks>
        /// <para>This parameter will be removed in the future. To ensure future compatibility, we recommend that you use other parameters.</para>
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
