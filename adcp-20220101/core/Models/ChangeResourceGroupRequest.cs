// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the new resource group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The resource ID. If ResourceType=cluster, the resource ID is ClusterId.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Only cluster are supported. Set the value to cluster.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
