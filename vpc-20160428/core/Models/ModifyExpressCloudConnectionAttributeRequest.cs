// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressCloudConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The local BGP autonomous system (AS) number to be configured on the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-ejfge***</para>
        /// </summary>
        [NameInMap("BgpAs")]
        [Validation(Required=false)]
        public string BgpAs { get; set; }

        /// <summary>
        /// <para>The cloud-side IP address used for peering with the Smart Access Gateway device.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c></para>
        /// </summary>
        [NameInMap("CeIp")]
        [Validation(Required=false)]
        public string CeIp { get; set; }

        /// <summary>
        /// <para>The description of the Express Cloud Connection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID of the Express Cloud Connection instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecc-bp1t9osmuln*******</para>
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

        /// <summary>
        /// <para>The name of the Express Cloud Connection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The local IP address of the Smart Access Gateway device used for peering with the cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.10.**.**</c></para>
        /// </summary>
        [NameInMap("PeIp")]
        [Validation(Required=false)]
        public string PeIp { get; set; }

        /// <summary>
        /// <para>The region ID of the Express Cloud Connection instance.</para>
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

    }

}
