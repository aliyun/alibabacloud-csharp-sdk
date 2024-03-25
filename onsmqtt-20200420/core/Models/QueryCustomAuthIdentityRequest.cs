// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthIdentityRequest : TeaModel {
        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("IdentityType")]
        [Validation(Required=false)]
        public string IdentityType { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
