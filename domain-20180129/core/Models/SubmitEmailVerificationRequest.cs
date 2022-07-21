// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitEmailVerificationRequest : TeaModel {
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SendIfExist")]
        [Validation(Required=false)]
        public bool? SendIfExist { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
