// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortConnsCountResponseBody : TeaModel {
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
        /// The number of new connections.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
