// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessPolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetPrivateAccessPolicyResponseBodyPolicy Policy { get; set; }
        public class GetPrivateAccessPolicyResponseBodyPolicy : TeaModel {
            [NameInMap("ApplicationIds")]
            [Validation(Required=false)]
            public List<string> ApplicationIds { get; set; }

            [NameInMap("ApplicationType")]
            [Validation(Required=false)]
            public string ApplicationType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomUserAttributes")]
            [Validation(Required=false)]
            public List<GetPrivateAccessPolicyResponseBodyPolicyCustomUserAttributes> CustomUserAttributes { get; set; }
            public class GetPrivateAccessPolicyResponseBodyPolicyCustomUserAttributes : TeaModel {
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

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PolicyAction")]
            [Validation(Required=false)]
            public string PolicyAction { get; set; }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            [NameInMap("UserGroupMode")]
            [Validation(Required=false)]
            public string UserGroupMode { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
