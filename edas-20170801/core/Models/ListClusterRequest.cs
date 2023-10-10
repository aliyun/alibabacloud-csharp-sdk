// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterRequest : TeaModel {
        /// <summary>
        /// The ID of the namespace. You can call the ListUserDefineRegion operation to query the namespace ID. For more information, see [ListUserDefineRegion](~~149377~~).
        /// 
        /// *   If this parameter is left empty, the clusters in the default namespace are queried.
        /// *   If this parameter is specified, the clusters in the specified namespace are queried.
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// The ID of the resource group. You can call the ListResourceGroup operation to query the resource group ID. For more information, see [ListResourceGroup](~~62055~~).
        /// 
        /// *   If this parameter is left empty, the clusters in the default resource group are queried.
        /// *   If this parameter is specified, the clusters in the specified resource group are queried.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
