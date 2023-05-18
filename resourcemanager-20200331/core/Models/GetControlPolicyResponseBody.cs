// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The details of the access control policy.
        /// </summary>
        [NameInMap("ControlPolicy")]
        [Validation(Required=false)]
        public GetControlPolicyResponseBodyControlPolicy ControlPolicy { get; set; }
        public class GetControlPolicyResponseBodyControlPolicy : TeaModel {
            /// <summary>
            /// The number of times that the access control policy is referenced.
            /// </summary>
            [NameInMap("AttachmentCount")]
            [Validation(Required=false)]
            public string AttachmentCount { get; set; }

            /// <summary>
            /// The time when the access control policy was created.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// The description of the access control policy.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The effective scope of the access control policy. Valid values:
            /// 
            /// *   All: The access control policy is in effect for Alibaba Cloud accounts, RAM users, and RAM roles.
            /// *   RAM: The access control policy is in effect only for RAM users and RAM roles.
            /// </summary>
            [NameInMap("EffectScope")]
            [Validation(Required=false)]
            public string EffectScope { get; set; }

            /// <summary>
            /// The document of the access control policy.
            /// </summary>
            [NameInMap("PolicyDocument")]
            [Validation(Required=false)]
            public string PolicyDocument { get; set; }

            /// <summary>
            /// The ID of the access control policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The name of the access control policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The type of the access control policy. Valid values:
            /// 
            /// *   System: system access control policy
            /// *   Custom: custom access control policy
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The time when the access control policy was updated.
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
