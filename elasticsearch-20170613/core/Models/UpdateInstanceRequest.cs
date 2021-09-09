// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ignoreStatus")]
        [Validation(Required=false)]
        public bool? IgnoreStatus { get; set; }

        [NameInMap("orderActionType")]
        [Validation(Required=false)]
        public string OrderActionType { get; set; }

    }

}
