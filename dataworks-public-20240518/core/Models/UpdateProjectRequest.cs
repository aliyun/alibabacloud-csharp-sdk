// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateProjectRequest : TeaModel {
        /// <summary>
        /// <para>An optional description of the workspace.</para>
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
        /// <item><description><para><c>true</c>: Enables the development environment for the workspace and isolates it from the production environment.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Uses only the production environment.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Important</b>: You cannot disable the development environment after you enable it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DevEnvironmentEnabled")]
        [Validation(Required=false)]
        public bool? DevEnvironmentEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the development role, which grants permissions for workflow and code editing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>false</c>: Enables the development role. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>true</c>: Disables the development role.</para>
        /// </description></item>
        /// </list>
        /// <para><b>Important</b>: After you enable the development role (by setting this parameter to <c>false</c>), you cannot disable it.</para>
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
        /// <para>The ID of the DataWorks workspace. To find the workspace ID, log in to the <a href="https://dataworks.console.aliyun.com/workspace/list">DataWorks console</a> and go to the Workspace Management page.</para>
        /// <para>This parameter specifies the DataWorks workspace to use for the API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable task scheduling for Machine Learning Platform for AI (PAI). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: You can create PAI nodes in the DataWorks workspace and run them on a schedule.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables task scheduling for PAI.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PaiTaskEnabled")]
        [Validation(Required=false)]
        public bool? PaiTaskEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Available</c>: Enables the workspace.</para>
        /// </description></item>
        /// <item><description><para><c>Forbidden</c>: Disables the workspace.</para>
        /// </description></item>
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
