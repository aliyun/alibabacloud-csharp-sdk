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
        /// <para>The ID of the preset workspace role. This operation overwrites existing roles. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>25: workspace administrator</description></item>
        /// <item><description>26: workspace developer</description></item>
        /// <item><description>27: workspace analyst</description></item>
        /// <item><description>30: workspace viewer</description></item>
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
        /// <para>The IDs of multiple workspace roles, separated by commas. If this parameter is specified, it takes precedence. <notice>roleId and roleIds cannot be both empty.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>25,26</para>
        /// </summary>
        [NameInMap("RoleIds")]
        [Validation(Required=false)]
        public string RoleIds { get; set; }

        /// <summary>
        /// <para>The Quick BI user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f5698bedeb384b1986afccd9e434****</para>
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
