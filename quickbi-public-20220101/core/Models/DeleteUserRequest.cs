// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DeleteUserRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the successor. If not empty, the report resources in the workspace of the deleted user will be transferred to the successor; otherwise, they will be transferred to the space owner.</para>
        /// <list type="bullet">
        /// <item><description>The successor cannot be an organization visitor</description></item>
        /// <item><description>The permissions of the successor in the workspace must not be less than those of the deleted user, with management permissions &gt; development permissions &gt; sharing permissions &gt; viewing permissions</description></item>
        /// <item><description>If the successor is not in the workspace, they will be automatically added to the workspace</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>f5****afccd9e434a274</para>
        /// </summary>
        [NameInMap("TransferUserId")]
        [Validation(Required=false)]
        public string TransferUserId { get; set; }

        /// <summary>
        /// <para>The ID of the user to be deleted. This user ID is the Quick BI UserID, not the Alibaba Cloud UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fe67f61a35a94b7da1a34ba174a7****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
