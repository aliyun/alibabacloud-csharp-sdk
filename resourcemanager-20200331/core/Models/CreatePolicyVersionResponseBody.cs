// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreatePolicyVersionResponseBody : TeaModel {
        /// <summary>
        /// The information of the policy version.
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public CreatePolicyVersionResponseBodyPolicyVersion PolicyVersion { get; set; }
        public class CreatePolicyVersionResponseBodyPolicyVersion : TeaModel {
            /// <summary>
            /// The time when the policy version was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// Indicates whether the policy version is the default version.
            /// </summary>
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }

            /// <summary>
            /// The ID of the policy version.
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
