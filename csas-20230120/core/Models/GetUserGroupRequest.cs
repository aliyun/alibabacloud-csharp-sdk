// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the user group. You can obtain the ID from the following sources:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListUserGroups~~">ListUserGroups</a>: Queries a list of user groups.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreateUserGroup~~">CreateUserGroup</a>: Creates a user group.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-6f1ef2fc56b6****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
