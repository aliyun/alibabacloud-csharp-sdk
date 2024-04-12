// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class SetPolicyCommandConfigRequest : TeaModel {
        [NameInMap("CommandConfig")]
        [Validation(Required=false)]
        public SetPolicyCommandConfigRequestCommandConfig CommandConfig { get; set; }
        public class SetPolicyCommandConfigRequestCommandConfig : TeaModel {
            [NameInMap("Approval")]
            [Validation(Required=false)]
            public SetPolicyCommandConfigRequestCommandConfigApproval Approval { get; set; }
            public class SetPolicyCommandConfigRequestCommandConfigApproval : TeaModel {
                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

            }

            [NameInMap("Deny")]
            [Validation(Required=false)]
            public SetPolicyCommandConfigRequestCommandConfigDeny Deny { get; set; }
            public class SetPolicyCommandConfigRequestCommandConfigDeny : TeaModel {
                [NameInMap("AclType")]
                [Validation(Required=false)]
                public string AclType { get; set; }

                [NameInMap("Commands")]
                [Validation(Required=false)]
                public List<string> Commands { get; set; }

            }

        }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
