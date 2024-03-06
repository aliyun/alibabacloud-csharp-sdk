// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreatePolicyResponseBody : TeaModel {
        /// <summary>
        /// The name of the access control rule.
        /// </summary>
        [NameInMap("AccessControlRules")]
        [Validation(Required=false)]
        public string AccessControlRules { get; set; }

        /// <summary>
        /// The ARN of the permission policy.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The scope of the permission policy.
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public string KmsInstance { get; set; }

        /// <summary>
        /// The name of the permission policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operations that can be performed.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The key and secret that are allowed to access.
        /// 
        /// *   `key/*` indicates that all keys of the KMS instance can be accessed.
        /// *   `secret/*` indicates all secrets of the KMS instance can be accessed.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
