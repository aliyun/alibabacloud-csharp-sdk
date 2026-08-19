// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class BatchDeletePrivateAccessPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of internal network access policies. You can specify up to 100 internal network access policy IDs.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

    }

}
