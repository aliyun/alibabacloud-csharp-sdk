// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ChangeResourceManagerResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource type.</para>
        /// <list type="bullet">
        /// <item><description>If you set ResourceType to project, set this parameter to the value of ProjectIdentifier. You can call the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation to obtain the value of ProjectIdentifier.</description></item>
        /// <item><description>If you set ResourceType to tenantresourcegroup, set this parameter to the value of ResourceGroupType. You can call the <a href="https://help.aliyun.com/document_detail/2780075.html">ListResourceGroups</a> operation to obtain the value of ResourceGroupType. Only the values 7, 8, and 9 are valid.</description></item>
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
        /// <para>The ID of the new resource group.</para>
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
        /// <item><description>project: workspace. If you want to change the resource group that you specify when you activate DataWorks, set the value to project.</description></item>
        /// <item><description>tenantresourcegroup: exclusive resource group. If you want to change the resource group that you specify when you purchase a DataWorks exclusive resource group, set the value to tenantresourcegroup.</description></item>
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
