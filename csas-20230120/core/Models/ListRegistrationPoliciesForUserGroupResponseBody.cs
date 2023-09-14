// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesForUserGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroups : TeaModel {
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies> Policies { get; set; }
            public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("LimitDetail")]
                [Validation(Required=false)]
                public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail> LimitDetail { get; set; }
                public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail : TeaModel {
                    [NameInMap("DeviceBelong")]
                    [Validation(Required=false)]
                    public string DeviceBelong { get; set; }

                    [NameInMap("LimitCount")]
                    [Validation(Required=false)]
                    public ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount LimitCount { get; set; }
                    public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount : TeaModel {
                        [NameInMap("All")]
                        [Validation(Required=false)]
                        public string All { get; set; }

                        [NameInMap("Mobile")]
                        [Validation(Required=false)]
                        public string Mobile { get; set; }

                        [NameInMap("PC")]
                        [Validation(Required=false)]
                        public string PC { get; set; }

                    }

                    [NameInMap("LimitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                }

                [NameInMap("MatchMode")]
                [Validation(Required=false)]
                public string MatchMode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<string> Whitelist { get; set; }

            }

            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
