// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetApplicationProvisioningScopeResponseBody : TeaModel {
        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of organizational units.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ou_xxx001]</para>
        /// </summary>
        [NameInMap("organizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

    }

}
