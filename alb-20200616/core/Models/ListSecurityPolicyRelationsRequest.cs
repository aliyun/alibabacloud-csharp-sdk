// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPolicyRelationsRequest : TeaModel {
        /// <summary>
        /// The security policy IDs. You can specify up to five IDs.
        /// </summary>
        [NameInMap("SecurityPolicyIds")]
        [Validation(Required=false)]
        public List<string> SecurityPolicyIds { get; set; }

    }

}
