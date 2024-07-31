// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudUnassignedMachinesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// The servers that are not assigned to the hybrid cloud cluster.
        /// </summary>
        [NameInMap("UnassignedMachines")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudUnassignedMachinesResponseBodyUnassignedMachines> UnassignedMachines { get; set; }
        public class DescribeHybridCloudUnassignedMachinesResponseBodyUnassignedMachines : TeaModel {
            /// <summary>
            /// The number of CPU cores.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public long? Cpu { get; set; }

            /// <summary>
            /// The name of the node.
            /// </summary>
            [NameInMap("CustomName")]
            [Validation(Required=false)]
            public string CustomName { get; set; }

            /// <summary>
            /// The host name.
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The media access control (MAC) address of the device.
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// The memory size. Unit: KB. A conversion factor of 1,000 is used.
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

        }

    }

}
