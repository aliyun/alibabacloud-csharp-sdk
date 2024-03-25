// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryCustomAuthPermissionRequest : TeaModel {
        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

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

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
