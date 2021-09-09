// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ShrinkNodeRequest : TeaModel {
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ignoreStatus")]
        [Validation(Required=false)]
        public bool? IgnoreStatus { get; set; }

    }

}
