// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the workspace. The description cannot exceed 80 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个工作空间描述示例。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>We recommend that you name the workspace based on its business attribute to facilitate identification of its purpose. If you do not configure this parameter, the workspace name is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo工作空间</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The environments included in the workspace:</para>
        /// <list type="bullet">
        /// <item><description>The simple mode contains only the production environment (prod).</description></item>
        /// <item><description>The standard mode contains both the development environment (dev) and the production environment (prod).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        /// <summary>
        /// <para>The resource group ID. For information about how to obtain the resource group ID, see <a href="https://help.aliyun.com/document_detail/151181.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwp7rkyq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the workspace. The format is as follows:</para>
        /// <list type="bullet">
        /// <item><description>The length is 3 to 23 characters and can contain letters, underscores (_), or digits.</description></item>
        /// <item><description>It must start with a letter (uppercase or lowercase).</description></item>
        /// <item><description>It must be unique within the current region.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace_example</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
