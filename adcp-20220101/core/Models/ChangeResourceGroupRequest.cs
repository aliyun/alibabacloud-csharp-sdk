// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the new resource group. You can view the available resource groups in the Resource Management console.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the resource. The value of this parameter varies with the resource type. For example, if you set ResourceType to cluster, this parameter specifies a cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to cluster.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
