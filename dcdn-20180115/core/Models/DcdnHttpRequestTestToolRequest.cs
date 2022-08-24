// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DcdnHttpRequestTestToolRequest : TeaModel {
        [NameInMap("Args")]
        [Validation(Required=false)]
        public string Args { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public Dictionary<string, object> Header { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProxyIp")]
        [Validation(Required=false)]
        public string ProxyIp { get; set; }

        [NameInMap("Scheme")]
        [Validation(Required=false)]
        public string Scheme { get; set; }

        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
