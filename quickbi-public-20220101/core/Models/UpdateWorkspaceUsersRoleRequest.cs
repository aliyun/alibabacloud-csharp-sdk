// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateWorkspaceUsersRoleRequest : TeaModel {
        /// <summary>
        /// <para>Preset space role ID, existing roles will be overwritten. Value range:</para>
        /// <list type="bullet">
        /// <item><description>25: Space Administrator</description></item>
        /// <item><description>26: Space Developer</description></item>
        /// <item><description>27: Space Analyst</description></item>
        /// <item><description>30: Space Viewer</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public long? RoleId { get; set; }

        /// <summary>
        /// <para>User ID. This is the UserID for Quick BI, not the UID for Alibaba Cloud.</para>
        /// <list type="bullet">
        /// <item><description>Supports batch parameters, separate user IDs with a comma (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136516262323****,124498444445****</para>
        /// </summary>
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

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
