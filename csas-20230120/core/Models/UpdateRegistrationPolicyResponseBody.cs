// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateRegistrationPolicyResponseBody : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public UpdateRegistrationPolicyResponseBodyPolicy Policy { get; set; }
        public class UpdateRegistrationPolicyResponseBodyPolicy : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("LimitDetail")]
            [Validation(Required=false)]
            public List<UpdateRegistrationPolicyResponseBodyPolicyLimitDetail> LimitDetail { get; set; }
            public class UpdateRegistrationPolicyResponseBodyPolicyLimitDetail : TeaModel {
                [NameInMap("DeviceBelong")]
                [Validation(Required=false)]
                public string DeviceBelong { get; set; }

                [NameInMap("LimitCount")]
                [Validation(Required=false)]
                public UpdateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount LimitCount { get; set; }
                public class UpdateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount : TeaModel {
                    [NameInMap("All")]
                    [Validation(Required=false)]
                    public int? All { get; set; }

                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public int? Mobile { get; set; }

                    [NameInMap("PC")]
                    [Validation(Required=false)]
                    public int? PC { get; set; }

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
            public string Priority { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
