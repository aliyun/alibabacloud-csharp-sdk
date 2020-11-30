// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListLayer7CustomPortsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Layer7CustomPorts")]
        [Validation(Required=true)]
        public List<ListLayer7CustomPortsResponseLayer7CustomPorts> Layer7CustomPorts { get; set; }
        public class ListLayer7CustomPortsResponseLayer7CustomPorts : TeaModel {
            [NameInMap("ProxyType")]
            [Validation(Required=true)]
            public string ProxyType { get; set; }

            [NameInMap("ProxyPorts")]
            [Validation(Required=true)]
            public List<string> ProxyPorts { get; set; }

        }

    }

}
