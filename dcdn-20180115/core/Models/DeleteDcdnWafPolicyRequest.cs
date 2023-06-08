// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnWafPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the protection policy that you want to delete. You can specify only one ID in each request.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

    }

}
