// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateVSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block for the vSwitch.\
        /// It must be a subnet of the VPC\&quot;s CIDR block and must not overlap with the CIDR blocks of other vSwitches in the same VPC.\</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. The token must be unique across requests, contain only ASCII characters, and not exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description for the vSwitch.\
        /// It must be 2 to 256 characters long and must not start with <c>http://</c> or <c>https://</c>.\</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the vSwitch.\
        /// Call the <c>DescribeRegions</c> operation to get a list of available regions.\</para>
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
        /// <para>The name for the vSwitch.\
        /// The name must be 2 to 128 characters long, start with a letter, and contain only letters, digits, underscores (_), and hyphens (-).\
        /// If unspecified, the name defaults to the vSwitch ID.\
        /// \</para>
        /// </summary>
        [NameInMap("VSwitchName")]
        [Validation(Required=false)]
        public string VSwitchName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which to create the vSwitch.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which to create the vSwitch.\
        /// Call the <c>DescribeZones</c> operation to get a list of available zones.\</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
