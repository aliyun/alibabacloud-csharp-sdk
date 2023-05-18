// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateControlPolicyRequest : TeaModel {
        /// <summary>
        /// The new description of the access control policy.
        /// 
        /// The description must be 1 to 1,024 characters in length. The description can contain letters, digits, underscores (\_), and hyphens (-) and must start with a letter.
        /// </summary>
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        /// <summary>
        /// The new document of the access control policy.
        /// 
        /// The document can be a maximum of 4,096 characters in length.
        /// 
        /// For more information about the languages of access control policies, see [Languages of access control policies](~~179096~~).
        /// 
        /// For more information about the examples of access control policies, see [Examples of custom access control policies](~~181474~~).
        /// </summary>
        [NameInMap("NewPolicyDocument")]
        [Validation(Required=false)]
        public string NewPolicyDocument { get; set; }

        /// <summary>
        /// The new name of the access control policy.
        /// 
        /// The name must be 1 to 128 characters in length. The name can contain letters, digits, and hyphens (-) and must start with a letter.
        /// </summary>
        [NameInMap("NewPolicyName")]
        [Validation(Required=false)]
        public string NewPolicyName { get; set; }

        /// <summary>
        /// The ID of the access control policy.
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
