// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesForUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>A collection of user group IDs. You can specify up to 100 user group IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
