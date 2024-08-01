// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostClusterAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the dedicated host cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// The new name of the dedicated host cluster. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter. The name cannot contain `http://` or `https://`.
        /// </summary>
        [NameInMap("DedicatedHostClusterName")]
        [Validation(Required=false)]
        public string DedicatedHostClusterName { get; set; }

        /// <summary>
        /// The description of the dedicated host cluster. It must be 2 to 256 characters in length. It cannot start with `http://` or `https://`.
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
        /// The region ID of the dedicated host cluster. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
