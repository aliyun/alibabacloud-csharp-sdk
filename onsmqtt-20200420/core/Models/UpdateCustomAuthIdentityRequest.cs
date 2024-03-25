// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class UpdateCustomAuthIdentityRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Secret")]
        [Validation(Required=false)]
        public string Secret { get; set; }

        [NameInMap("SignMode")]
        [Validation(Required=false)]
        public string SignMode { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
