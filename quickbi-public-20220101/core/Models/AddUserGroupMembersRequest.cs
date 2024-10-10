// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserGroupMembersRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the user groups. Separate the IDs with commas (,). Example: aGroupId,bGroupId,cGroupIds</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0d5fb19b-<b><b>-</b></b>-99da-1248fc27ca51</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        /// <summary>
        /// <para>The user ID of the Quick BI.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e5****37a5</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
