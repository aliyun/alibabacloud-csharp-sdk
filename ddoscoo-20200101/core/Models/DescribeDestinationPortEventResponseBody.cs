// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDestinationPortEventResponseBody : TeaModel {
        /// <summary>
        /// The ports.
        /// </summary>
        [NameInMap("PortList")]
        [Validation(Required=false)]
        public List<DescribeDestinationPortEventResponseBodyPortList> PortList { get; set; }
        public class DescribeDestinationPortEventResponseBodyPortList : TeaModel {
            /// <summary>
            /// The destination port.
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public string DstPort { get; set; }

            /// <summary>
            /// The number of request packets received by the destination port.
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
