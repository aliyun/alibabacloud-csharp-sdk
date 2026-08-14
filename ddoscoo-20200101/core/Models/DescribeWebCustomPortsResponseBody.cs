// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCustomPortsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebCustomPorts")]
        [Validation(Required=false)]
        public List<DescribeWebCustomPortsResponseBodyWebCustomPorts> WebCustomPorts { get; set; }
        public class DescribeWebCustomPortsResponseBodyWebCustomPorts : TeaModel {
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<string> ProxyPorts { get; set; }

            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

    }

}
