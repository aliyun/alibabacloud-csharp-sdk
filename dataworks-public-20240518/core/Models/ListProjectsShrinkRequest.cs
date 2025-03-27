// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the workspaces belong. You can log on to the <a href="https://resourcemanager.console.aliyun.com/resource-groups">Resource Management console</a> and go to the Resource Group page to query the ID.</para>
        /// <para>This parameter is used to query the information about workspaces that belong to a specific resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzbn7pti3zff</para>
        /// </summary>
        [NameInMap("AliyunResourceGroupId")]
        [Validation(Required=false)]
        public string AliyunResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("AliyunResourceTags")]
        [Validation(Required=false)]
        public string AliyunResourceTagsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the development environment is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The development environment is enabled. In this case, the development environment is isolated from the production environment in a workspace.</description></item>
        /// <item><description>false: The development environment is disabled. In this case, only the production environment is used in a workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DevEnvironmentEnabled")]
        [Validation(Required=false)]
        public bool? DevEnvironmentEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether the Develop role is disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default)</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DevRoleDisabled")]
        [Validation(Required=false)]
        public bool? DevRoleDisabled { get; set; }

        /// <summary>
        /// <para>The IDs of the DataWorks workspaces.</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string IdsShrink { get; set; }

        /// <summary>
        /// <para>The names of the DataWorks workspaces.</para>
        /// </summary>
        [NameInMap("Names")]
        [Validation(Required=false)]
        public string NamesShrink { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether scheduling of Platform for AI (PAI) tasks is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Scheduling of PAI tasks is enabled. In this case, you can create a PAI node in a DataWorks workspace and configure scheduling properties for the node to implement periodic scheduling of PAI tasks.</description></item>
        /// <item><description>false: Scheduling of PAI tasks is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PaiTaskEnabled")]
        [Validation(Required=false)]
        public bool? PaiTaskEnabled { get; set; }

        /// <summary>
        /// <para>The status of the workspaces. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available</description></item>
        /// <item><description>Initializing</description></item>
        /// <item><description>InitFailed</description></item>
        /// <item><description>Forbidden</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>DeleteFailed</description></item>
        /// <item><description>Frozen</description></item>
        /// <item><description>Updating</description></item>
        /// <item><description>UpdateFailed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
