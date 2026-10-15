// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddWorkspaceUsersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the preset workspace role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>25: storage management administrator</description></item>
        /// <item><description>26: workspace developer</description></item>
        /// <item><description>27: storage analysis analyst</description></item>
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
        /// <para>The user IDs. These are Quick BI user IDs, not Alibaba Cloud UIDs.</para>
        /// <list type="bullet">
        /// <item><description>You can pass multiple user IDs separated by commas (,).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de4bc5f9429141cc8091cdd1c15b****</para>
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
