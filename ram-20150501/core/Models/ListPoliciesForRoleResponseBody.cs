// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForRoleResponseBody : TeaModel {
        /// <summary>
        /// The list of the policies that are attached to the RAM role.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForRoleResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForRoleResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForRoleResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForRoleResponseBodyPoliciesPolicy : TeaModel {
                /// <summary>
                /// The time when the policy was attached to the RAM role.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

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
