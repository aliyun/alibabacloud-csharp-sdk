// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafPolicyRequest : TeaModel {
        /// <summary>
        /// The ID of the protection policy that you want to modify. You can specify only one ID in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// The new name of the protection policy.
        /// 
        /// > You must specify PolicyName or PolicyStatus.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The new status of the protection policy. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// 
        /// > You must specify PolicyName or PolicyStatus.
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

    }

}
