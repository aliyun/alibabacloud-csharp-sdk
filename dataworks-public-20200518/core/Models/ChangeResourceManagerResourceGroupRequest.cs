// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ChangeResourceManagerResourceGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the resource type.
        /// 
        /// *   If you set ResourceType to project, set this parameter to the value of ProjectIdentifier. You can call the [ListProjects](https://help.aliyun.com/document_detail/2780068.html) operation to obtain the value of ProjectIdentifier.
        /// *   If you set ResourceType to tenantresourcegroup, set this parameter to the value of ResourceGroupType. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/2780075.html) operation to obtain the value of ResourceGroupType. Only the values 7, 8, and 9 are valid.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The ID of the new resource group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// The resource type. Valid values:
        /// 
        /// *   project: workspace. If you want to change the resource group that you specify when you activate DataWorks, set the value to project.
        /// *   tenantresourcegroup: exclusive resource group. If you want to change the resource group that you specify when you purchase a DataWorks exclusive resource group, set the value to tenantresourcegroup.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
