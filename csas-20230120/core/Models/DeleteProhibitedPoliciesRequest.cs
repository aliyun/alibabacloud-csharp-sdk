// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeleteProhibitedPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the software prohibition policies to delete. Duplicate IDs are not allowed. You can specify up to 100 IDs.</para>
        /// </summary>
        [NameInMap("PolicyIds")]
        [Validation(Required=false)]
        public List<string> PolicyIds { get; set; }

    }

}
