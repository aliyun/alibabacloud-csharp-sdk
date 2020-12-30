// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListLayer7CustomPortsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Layer7CustomPorts")]
        [Validation(Required=false)]
        public List<ListLayer7CustomPortsResponseBodyLayer7CustomPorts> Layer7CustomPorts { get; set; }
        public class ListLayer7CustomPortsResponseBodyLayer7CustomPorts : TeaModel {
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<string> ProxyPorts { get; set; }

            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

    }

}
