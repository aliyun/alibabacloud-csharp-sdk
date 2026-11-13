// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ChangeResourceManagerResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ResourceType is set to project, ResourceId is the name of the workspace (ProjectIdentifier) obtained by calling the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation.</description></item>
        /// <item><description>If ResourceType is set to tenantresourcegroup, ResourceId is the identifier of the exclusive resource group (Identifier) obtained by calling the <a href="https://help.aliyun.com/document_detail/2780075.html">ListResourceGroups</a> operation. This applies only to resource groups whose ResourceGroupType is 7, 8, or 9.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The ID of the destination resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>project: workspace. Select this value if you want to modify the resource group to which a DataWorks workspace belongs.</description></item>
        /// <item><description>tenantresourcegroup: exclusive resource group. Select this value if you want to modify the resource group to which a DataWorks exclusive resource group belongs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
