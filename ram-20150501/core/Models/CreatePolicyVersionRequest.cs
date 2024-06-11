// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class CreatePolicyVersionRequest : TeaModel {
        /// <summary>
        /// The document of the policy. The document can be up to 6,144 bytes in length.
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The rotation strategy of the policy. The rotation strategy can be used to delete an early policy version.
        /// 
        /// Valid values:
        /// 
        /// *   `None`: disables the rotation strategy.
        /// *   `DeleteOldestNonDefaultVersionWhenLimitExceeded`: deletes the earliest non-active version if the number of versions exceeds the limit.
        /// 
        /// Default value: `None`.
        /// </summary>
        [NameInMap("RotateStrategy")]
        [Validation(Required=false)]
        public string RotateStrategy { get; set; }

        /// <summary>
        /// Specifies whether to set this policy as the default policy. Default value: `false`.
        /// </summary>
        [NameInMap("SetAsDefault")]
        [Validation(Required=false)]
        public bool? SetAsDefault { get; set; }

    }

}
