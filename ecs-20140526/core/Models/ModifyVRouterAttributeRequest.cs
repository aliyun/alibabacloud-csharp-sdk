// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyVRouterAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the virtual router. The description must be 2 to 256 characters long and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The ID of the region where the virtual router is deployed. You can call the <c>DescribeRegions</c> operation to obtain the most recent list of regions.</para>
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
        /// <para>The ID of the VRouter to modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VRouterId")]
        [Validation(Required=false)]
        public string VRouterId { get; set; }

        /// <summary>
        /// <para>The name of the virtual router. The name must be 2 to 128 characters long and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </summary>
        [NameInMap("VRouterName")]
        [Validation(Required=false)]
        public string VRouterName { get; set; }

    }

}
