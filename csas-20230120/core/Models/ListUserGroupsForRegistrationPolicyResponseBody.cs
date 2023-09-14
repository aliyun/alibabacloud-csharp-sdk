// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsForRegistrationPolicyResponseBody : TeaModel {
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListUserGroupsForRegistrationPolicyResponseBodyPolicies> Policies { get; set; }
        public class ListUserGroupsForRegistrationPolicyResponseBodyPolicies : TeaModel {
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups> UserGroups { get; set; }
            public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroups : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes> Attributes { get; set; }
                public class ListUserGroupsForRegistrationPolicyResponseBodyPoliciesUserGroupsAttributes : TeaModel {
                    [NameInMap("IdpId")]
                    [Validation(Required=false)]
                    public int? IdpId { get; set; }

                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                    [NameInMap("UserGroupType")]
                    [Validation(Required=false)]
                    public string UserGroupType { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UserGroupId")]
                [Validation(Required=false)]
                public string UserGroupId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
