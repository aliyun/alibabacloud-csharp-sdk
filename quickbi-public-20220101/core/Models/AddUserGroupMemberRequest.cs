// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>555c4cd****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the Quick BI user. Separate multiple IDs with commas (,). Example: abc,efg. You can enter a maximum of 1000 entries.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

    }

}
