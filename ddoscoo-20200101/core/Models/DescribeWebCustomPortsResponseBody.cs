// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCustomPortsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of information about supported custom ports that are used by a website.
        /// </summary>
        [NameInMap("WebCustomPorts")]
        [Validation(Required=false)]
        public List<DescribeWebCustomPortsResponseBodyWebCustomPorts> WebCustomPorts { get; set; }
        public class DescribeWebCustomPortsResponseBodyWebCustomPorts : TeaModel {
            /// <summary>
            /// An array that consists of supported custom ports.
            /// </summary>
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<string> ProxyPorts { get; set; }

            /// <summary>
            /// The type of the protocol. Valid values:
            /// 
            /// *   **http**
            /// *   **https**
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

    }

}
