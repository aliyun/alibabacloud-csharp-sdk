// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class AddUserGroupMemberRequest : TeaModel {
        /// <summary>
        /// <para>The command to add user group members.</para>
        /// </summary>
        [NameInMap("AddCommand")]
        [Validation(Required=false)]
        public AddUserGroupMemberRequestAddCommand AddCommand { get; set; }
        public class AddUserGroupMemberRequestAddCommand : TeaModel {
            /// <summary>
            /// <para>The user group ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132331</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

            /// <summary>
            /// <para>The list of user IDs.</para>
            /// </summary>
            [NameInMap("UserIdList")]
            [Validation(Required=false)]
            public List<string> UserIdList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
