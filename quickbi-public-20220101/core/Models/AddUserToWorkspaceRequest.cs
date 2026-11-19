// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserToWorkspaceRequest : TeaModel {
        /// <summary>
        /// <para>The workspace role ID. Preset roles:</para>
        /// <list type="bullet">
        /// <item><description>25: Workspace administrator</description></item>
        /// <item><description>26: Workspace developer</description></item>
        /// <item><description>27: Workspace analyst</description></item>
        /// <item><description>30: Workspace viewer</description></item>
        /// </list>
        /// <remarks>
        /// <para>Custom role IDs are supported since 6.0.3.</para>
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
        /// <para>The ID of the Quick BI user to add.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
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
