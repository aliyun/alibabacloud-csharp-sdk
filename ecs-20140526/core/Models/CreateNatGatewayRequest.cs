// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateNatGatewayRequest : TeaModel {
        /// <summary>
        /// <para>Configurations for the bandwidth packages to create and associate with the nat gateway.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BandwidthPackage")]
        [Validation(Required=false)]
        public List<CreateNatGatewayRequestBandwidthPackage> BandwidthPackage { get; set; }
        public class CreateNatGatewayRequestBandwidthPackage : TeaModel {
            /// <summary>
            /// <para>The peak bandwidth for the EIPs in the bandwidth package. Unit: Mbit/s.</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The number of EIPs to create in the bandwidth package. Valid values: 1 to 10.</para>
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public int? IpCount { get; set; }

            /// <summary>
            /// <para>The ID of the zone in which to create the EIPs. If you do not specify a zone, the system randomly selects one.</para>
            /// </summary>
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request.</para>
        /// <para>This token is client-generated and must be unique for each request. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>A description of the nat gateway.</para>
        /// <para>The description must be 2 to 256 characters in length. It must start with a letter or a Chinese character but cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A name for the nat gateway.</para>
        /// <para>The name must be 2 to 128 characters in length. It must start with a letter or a Chinese character but cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The ID of the region in which to create the nat gateway.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The ID of the VPC in which to create the nat gateway.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
