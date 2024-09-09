// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class UpdateInstanceAccountRequest : TeaModel {
        [NameInMap("accountStatus")]
        [Validation(Required=false)]
        public string AccountStatus { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

    }

}
