// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the response is truncated.
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The marker. This parameter is returned only if the value of `IsTruncated` is `true`. If the value of IsTruncated is `true`, you can call this operation again and set `Marker` to obtain the truncated part.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The list of policies.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesResponseBodyPoliciesPolicy : TeaModel {
                /// <summary>
                /// The number of references to the policy.
                /// </summary>
                [NameInMap("AttachmentCount")]
                [Validation(Required=false)]
                public int? AttachmentCount { get; set; }

                /// <summary>
                /// The time when the policy was created.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The default version of the policy.
                /// </summary>
                [NameInMap("DefaultVersion")]
                [Validation(Required=false)]
                public string DefaultVersion { get; set; }

                /// <summary>
                /// The description of the policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the policy.
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// The type of the policy.
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// The time when the policy was modified.
                /// </summary>
                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
