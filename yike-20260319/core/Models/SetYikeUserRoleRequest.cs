// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260319.Models
{
    public class SetYikeUserRoleRequest : TeaModel {
        /// <summary>
        /// <para>The role of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SuperAdmin: super administrator.</description></item>
        /// <item><description>Admin: administrator.</description></item>
        /// <item><description>RegularUser: regular member.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Admin</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The ID of the sub-account user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("YikeUserId")]
        [Validation(Required=false)]
        public string YikeUserId { get; set; }

    }

}
