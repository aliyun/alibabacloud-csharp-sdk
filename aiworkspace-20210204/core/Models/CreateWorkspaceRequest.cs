// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The description of the workspace. The description can be up to 80 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the workspace. You can set it based on the purpose of the workspace. If left empty, the name of the workspace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>display name</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The environment of the workspace.</para>
        /// <list type="bullet">
        /// <item><description>Workspaces in basic mode can run only in the production environment (prod).</description></item>
        /// <item><description>Workspaces in standard mode can run in both the development and production environments (dev and prod).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EnvTypes")]
        [Validation(Required=false)]
        public List<string> EnvTypes { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the workspace. Format:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 3 to 23 characters in length, and can contain letters, underscores (_), and digits.</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>It must be unique in the current region.</description></item>
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
