// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetYikeUserRoleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Admin</para>
        /// </summary>
        [NameInMap("RoleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>id</para>
        /// </summary>
        [NameInMap("YikeUserId")]
        [Validation(Required=false)]
        public string YikeUserId { get; set; }

    }

}
