// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnWafPolicyResponseBody : TeaModel {
        /// <summary>
        /// The name of the protection policy. The name can be up to 64 characters in length and can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// Specifies whether to set the current policy as the default policy. Valid values:
        /// 
        /// *   default: sets the current policy as the default policy.
        /// *   custom: does not set the current policy as the default policy.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
