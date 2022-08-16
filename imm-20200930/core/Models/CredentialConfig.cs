// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CredentialConfig : TeaModel {
        [NameInMap("Chain")]
        [Validation(Required=false)]
        public List<CredentialConfigChain> Chain { get; set; }
        public class CredentialConfigChain : TeaModel {
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public string AssumeRoleFor { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

        }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("ServiceRole")]
        [Validation(Required=false)]
        public string ServiceRole { get; set; }

    }

}
