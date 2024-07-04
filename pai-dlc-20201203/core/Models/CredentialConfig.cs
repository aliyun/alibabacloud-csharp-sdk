// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CredentialConfig : TeaModel {
        [NameInMap("AliyunEnvRoleKey")]
        [Validation(Required=false)]
        public string AliyunEnvRoleKey { get; set; }

        [NameInMap("CredentialConfigItems")]
        [Validation(Required=false)]
        public List<CredentialConfigItem> CredentialConfigItems { get; set; }

        [NameInMap("EnableCredentialInject")]
        [Validation(Required=false)]
        public bool? EnableCredentialInject { get; set; }

    }

}
