// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserToWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the role in the workspace. Predefined roles:</para>
        /// <list type="bullet">
        /// <item><description><para>25: workspace administrator</para>
        /// </description></item>
        /// <item><description><para>26: workspace developer</para>
        /// </description></item>
        /// <item><description><para>27: workspace analyst</para>
        /// </description></item>
        /// <item><description><para>30: workspace viewer</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Custom role IDs are supported in version 6.0.3 and later.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// <para>The ID of the Quick BI user to be added.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
