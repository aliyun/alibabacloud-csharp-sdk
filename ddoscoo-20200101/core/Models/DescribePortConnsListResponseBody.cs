// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortConnsListResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the connections established over the port.
        /// </summary>
        [NameInMap("ConnsList")]
        [Validation(Required=false)]
        public List<DescribePortConnsListResponseBodyConnsList> ConnsList { get; set; }
        public class DescribePortConnsListResponseBodyConnsList : TeaModel {
            /// <summary>
            /// The number of active connections.
            /// </summary>
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public long? ActConns { get; set; }

            /// <summary>
            /// The number of concurrent connections.
            /// </summary>
            [NameInMap("Conns")]
            [Validation(Required=false)]
            public long? Conns { get; set; }

            /// <summary>
            /// The new connection creation rate.
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// The number of inactive connections.
            /// </summary>
            [NameInMap("InActConns")]
            [Validation(Required=false)]
            public long? InActConns { get; set; }

            /// <summary>
            /// The index number of the returned data.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
