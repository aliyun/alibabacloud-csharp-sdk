// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeSessionListResponseBody : TeaModel {
        /// <summary>
        /// The object information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeSessionListResponseBodyData> Data { get; set; }
        public class DescribeSessionListResponseBodyData : TeaModel {
            /// <summary>
            /// The address of the client, with the format ip:port.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// The session ID of the proxy service.
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
