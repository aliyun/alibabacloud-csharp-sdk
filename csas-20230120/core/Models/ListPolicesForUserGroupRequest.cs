// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the user groups. You can enter up to 100 user group IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
