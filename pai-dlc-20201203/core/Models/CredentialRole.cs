// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CredentialRole : TeaModel {
        [NameInMap("AssumeRoleFor")]
        [Validation(Required=false)]
        public string AssumeRoleFor { get; set; }

        [NameInMap("AssumeUserInfo")]
        [Validation(Required=false)]
        public AssumeUserInfo AssumeUserInfo { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
