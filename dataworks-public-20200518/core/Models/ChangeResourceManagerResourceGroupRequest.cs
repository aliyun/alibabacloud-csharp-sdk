// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ChangeResourceManagerResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource. The value of this parameter depends on the value of the ResourceType parameter:</para>
        /// <list type="bullet">
        /// <item><description><para>If ResourceType is set to project, this parameter specifies the name of the workspace (ProjectIdentifier). You can call the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation to obtain the workspace name.</para>
        /// </description></item>
        /// <item><description><para>If ResourceType is set to tenantresourcegroup, this parameter specifies the identifier of the exclusive resource group (Identifier). You can call the <a href="https://help.aliyun.com/document_detail/2780075.html">ListResourceGroups</a> operation to obtain the identifier. This applies only to resource groups of type 7, 8, or 9.</para>
        /// </description></item>
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
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>project: a workspace. Select this value to change the resource group for a DataWorks edition.</para>
        /// </description></item>
        /// <item><description><para>tenantresourcegroup: an exclusive resource group. Select this value to change the resource group for a DataWorks exclusive resource group.</para>
        /// </description></item>
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
