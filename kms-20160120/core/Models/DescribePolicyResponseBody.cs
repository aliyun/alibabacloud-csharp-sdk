// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribePolicyResponseBody : TeaModel {
        /// <summary>
        /// The network access rule that is associated with the permission policy.
        /// </summary>
        [NameInMap("AccessControlRules")]
        [Validation(Required=false)]
        public string AccessControlRules { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the permission policy.
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
        /// A list of operations that can be performed.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of keys and secrets that are allowed to access.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<string> Resources { get; set; }

    }

}
