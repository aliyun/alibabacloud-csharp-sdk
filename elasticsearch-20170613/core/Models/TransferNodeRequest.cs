// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class TransferNodeRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<TransferNodeRequestBody> Body { get; set; }
        public class TransferNodeRequestBody : TeaModel {
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

    }

}
