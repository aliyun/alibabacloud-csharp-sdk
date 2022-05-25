// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GetApplicationProvisioningScopeResponseBody : TeaModel {
        /// <summary>
        /// 机构ID列表
        /// </summary>
        [NameInMap("organizationalUnitIds")]
        [Validation(Required=false)]
        public List<string> OrganizationalUnitIds { get; set; }

    }

}
