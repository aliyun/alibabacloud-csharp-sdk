// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUuidsByVulNamesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the statistics about the assets.
        /// </summary>
        [NameInMap("MachineInfoStatistics")]
        [Validation(Required=false)]
        public List<DescribeUuidsByVulNamesResponseBodyMachineInfoStatistics> MachineInfoStatistics { get; set; }
        public class DescribeUuidsByVulNamesResponseBodyMachineInfoStatistics : TeaModel {
            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("MachineInstanceId")]
            [Validation(Required=false)]
            public string MachineInstanceId { get; set; }

            /// <summary>
            /// The IP address of the server.
            /// </summary>
            [NameInMap("MachineIp")]
            [Validation(Required=false)]
            public string MachineIp { get; set; }

            /// <summary>
            /// The name of the server.
            /// </summary>
            [NameInMap("MachineName")]
            [Validation(Required=false)]
            public string MachineName { get; set; }

            /// <summary>
            /// The name of the operating system that the server runs.
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// The ID of the region in which the server resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The UUID of the server.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
