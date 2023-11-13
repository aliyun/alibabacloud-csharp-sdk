// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortMaxConnsResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the details of the maximum number of connections that are established over a port of the instance.
        /// </summary>
        [NameInMap("PortMaxConns")]
        [Validation(Required=false)]
        public List<DescribePortMaxConnsResponseBodyPortMaxConns> PortMaxConns { get; set; }
        public class DescribePortMaxConnsResponseBodyPortMaxConns : TeaModel {
            /// <summary>
            /// The maximum number of connections per second (CPS).
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The port of the instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
