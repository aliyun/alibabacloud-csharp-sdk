// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetYikeUserRoleRequest : TeaModel {
        /// <summary>
        /// <para>The user role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SuperAdmin: Super Admin.</para>
        /// </description></item>
        /// <item><description><para>Admin: Admin.</para>
        /// </description></item>
        /// <item><description><para>RegularUser: Regular User.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Admin</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <para>The sub-account user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("YikeUserId")]
        [Validation(Required=false)]
        public string YikeUserId { get; set; }

    }

}
