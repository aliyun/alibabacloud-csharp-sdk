// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUserResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the ports that can be used by a hybrid cloud cluster.
        /// </summary>
        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public DescribeHybridCloudUserResponseBodyUserInfo UserInfo { get; set; }
        public class DescribeHybridCloudUserResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// The HTTP ports. The value is a string. If multiple ports are returned, the value is in the **port1,port2,port3** format.
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public string HttpPorts { get; set; }

            /// <summary>
            /// The HTTPS ports. The value is a string. If multiple ports are returned, the value is in the **port1,port2,port3** format.
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public string HttpsPorts { get; set; }

        }

    }

}
