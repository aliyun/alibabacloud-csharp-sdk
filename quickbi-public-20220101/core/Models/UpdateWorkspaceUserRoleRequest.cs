// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateWorkspaceUserRoleRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Preset workspace role ID, existing roles will be overwritten. Value range:</para>
        /// <list type="bullet">
        /// <item><description>25: Workspace Administrator</description></item>
        /// <item><description>26: Workspace Developer</description></item>
        /// <item><description>27: Workspace Analyst</description></item>
        /// <item><description>30: Workspace Viewer</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? RoleId { get; set; }

        /// <summary>
        /// <para>Multiple workspace role IDs, separated by commas. If this value is provided, it takes precedence.</para>
        /// <remarks>
        /// <para>Notice: roleId and roleIds cannot both be empty</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>25,26</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>Quick BI user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f5698bedeb384b1986afccd9e434****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Workspace ID.</para>
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
