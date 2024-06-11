// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListPoliciesForUserResponseBody : TeaModel {
        /// <summary>
        /// The information about the policy.
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public ListPoliciesForUserResponseBodyPolicies Policies { get; set; }
        public class ListPoliciesForUserResponseBodyPolicies : TeaModel {
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public List<ListPoliciesForUserResponseBodyPoliciesPolicy> Policy { get; set; }
            public class ListPoliciesForUserResponseBodyPoliciesPolicy : TeaModel {
                /// <summary>
                /// The time at which the policy is attached to the RAM user. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The current version.
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
                /// The type of the policy. Valid values:
                /// 
                /// *   System: system policy
                /// *   Custom: custom policy
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
