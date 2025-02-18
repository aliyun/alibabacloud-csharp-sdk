// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProjectRequest : TeaModel {
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
        /// <item><description>true: enables the development environment. In this case, the development environment is isolated from the production environment in the workspace.</description></item>
        /// <item><description>false: disables the development environment. In this case, only the production environment is used in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>Note: If you disable the Develop role, you cannot assume the Develop role to develop nodes in workflows and edit node code. The Develop role cannot be enabled again after it is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DevRoleDisabled")]
        [Validation(Required=false)]
        public bool? DevRoleDisabled { get; set; }

        /// <summary>
        /// <para>The display name of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sora financial analysis Space</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter is used to determine the DataWorks workspaces used for this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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

        /// <summary>
        /// <para>Specifies whether to disable or enable the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Available: enables the workspace.</description></item>
        /// <item><description>Forbidden: disables the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
