// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateProjectRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group to which the workspace belongs. You can log on to the <a href="https://resourcemanager.console.aliyun.com/resource-groups">Resource Management console</a> and go to the Resource Group page to query the ID.</para>
        /// <para>You must configure this parameter to specify an Alibaba Cloud resource group for the workspace that you want to create.</para>
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
        public List<CreateProjectRequestAliyunResourceTags> AliyunResourceTags { get; set; }
        public class CreateProjectRequestAliyunResourceTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>batch</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>blue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Financial analysis group project data development</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the development environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true : enables the development environment. In this case, the development environment is isolated from the production environment in the workspace.</description></item>
        /// <item><description>false: disables the development environment. In this case, only the production environment is used in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DevEnvironmentEnabled")]
        [Validation(Required=false)]
        public bool? DevEnvironmentEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the Develop role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default)</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DevRoleDisabled")]
        [Validation(Required=false)]
        public bool? DevRoleDisabled { get; set; }

        /// <summary>
        /// <para>The display name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sora financial analysis</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The workspace name must be unqiue in a region.</description></item>
        /// <item><description>The workspace name can contain letters, digits, and underscores (_), and must start with a letter.</description></item>
        /// <item><description>The workspace name must be 3 to 28 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sora_finance</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable scheduling of Platform for AI (PAI) tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables scheduling of PAI tasks. In this case, you can create a PAI node in a DataWorks workspace and configure scheduling properties for the node to implement periodic scheduling of PAI tasks.</description></item>
        /// <item><description>false: disables scheduling of PAI tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PaiTaskEnabled")]
        [Validation(Required=false)]
        public bool? PaiTaskEnabled { get; set; }

    }

}
