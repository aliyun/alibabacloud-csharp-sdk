// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ChangeResourceManagerResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the resource type. Valid values:
        /// 
        /// *   If you set the ResourceType parameter to project, set this parameter to the value of ProjectIdentifier. You can call the [ListProjects](~~178393~~) operation to obtain the value of ProjectIdentifier.
        /// *   If you set the ResourceType parameter to tenantresourcegroup, set this parameter to the value of ResourceGroupType. You can call the [ListResourceGroups](~~173913~~) operation to obtain the value of ResourceGroupType. Only the values 7, 8, and 9 are valid.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The ID of the new resource group.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   project: workspace. If you want to modify the resource group that you specify when you activate DataWorks, set the value to project.
        /// *   tenantresourcegroup: exclusive resource group. If you want to modify the resource group that you specify when you purchase a DataWorks exclusive resource group, set the value to tenantresourcegroup.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
