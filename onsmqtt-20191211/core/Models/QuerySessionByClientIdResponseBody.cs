// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20191211.Models
{
    public class QuerySessionByClientIdResponseBody : TeaModel {
        [NameInMap("OnlineStatus")]
        [Validation(Required=false)]
        public bool? OnlineStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
