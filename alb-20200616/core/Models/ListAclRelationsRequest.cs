// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclRelationsRequest : TeaModel {
        /// <summary>
        /// <para>The access control list (ACL) IDs. You can query at most five ACLs in each call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public List<string> AclIds { get; set; }

    }

}
