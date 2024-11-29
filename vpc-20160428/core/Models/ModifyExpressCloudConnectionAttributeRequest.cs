// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressCloudConnectionAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The BGP autonomous system number (ASN) to be configured for the Smart Access Gateway (SAG) device.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-ejfge***</para>
        /// </summary>
        [NameInMap("BgpAs")]
        [Validation(Required=false)]
        public string BgpAs { get; set; }

        /// <summary>
        /// <para>The peer IP address when the SAG device is connected to the cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c></para>
        /// </summary>
        [NameInMap("CeIp")]
        [Validation(Required=false)]
        public string CeIp { get; set; }

        /// <summary>
        /// <para>Descriptions of ECC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECC</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the ECC instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecc-bp1t9osmuln*******</para>
        /// </summary>
        [NameInMap("EccId")]
        [Validation(Required=false)]
        public string EccId { get; set; }

        /// <summary>
        /// <para>The name of the ECC instance.</para>
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
        /// <para>The on-premises IP address when the SAG device is connected to the cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>10.10.**.**</c></para>
        /// </summary>
        [NameInMap("PeIp")]
        [Validation(Required=false)]
        public string PeIp { get; set; }

        /// <summary>
        /// <para>The region ID of the ECC instance.</para>
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
