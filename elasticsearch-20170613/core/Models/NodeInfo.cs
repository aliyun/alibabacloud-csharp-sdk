// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeInfo : TeaModel {
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("hostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
