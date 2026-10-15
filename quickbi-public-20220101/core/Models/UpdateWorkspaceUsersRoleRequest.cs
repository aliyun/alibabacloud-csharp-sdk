// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateWorkspaceUsersRoleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the preset workspace role. Existing roles are overwritten. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>25: workspace administrator</description></item>
        /// <item><description>26: workspace developer</description></item>
        /// <item><description>27: workspace analyst</description></item>
        /// <item><description>30: workspace viewer</description></item>
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
        /// <para>The user IDs. The IDs are Quick BI user IDs, not Alibaba Cloud UIDs.</para>
        /// <list type="bullet">
        /// <item><description>You can specify multiple user IDs separated by commas (,).</description></item>
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
