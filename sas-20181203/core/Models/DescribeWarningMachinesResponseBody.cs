// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWarningMachinesResponseBody : TeaModel {
        /// <summary>
        /// The verification status of the risk item after the risk item is fixed. Valid values:
        /// 
        /// *   **1**: complete
        /// *   **2**: verifying
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The name of the server on which the baseline check is performed.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// An array that consists of the servers.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The value of the field that is used to search for the container.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The ID of the container cluster.
        /// 
        /// >  You can call the [DescribeGroupedContainerInstances](~~DescribeGroupedContainerInstances~~) operation to query the IDs of container clusters.
        /// </summary>
        [NameInMap("WarningMachines")]
        [Validation(Required=false)]
        public List<DescribeWarningMachinesResponseBodyWarningMachines> WarningMachines { get; set; }
        public class DescribeWarningMachinesResponseBodyWarningMachines : TeaModel {
            [NameInMap("AuthVersion")]
            [Validation(Required=false)]
            public int? AuthVersion { get; set; }

            [NameInMap("Bind")]
            [Validation(Required=false)]
            public bool? Bind { get; set; }

            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// The public IP address of the server.
            /// </summary>
            [NameInMap("HighWarningCount")]
            [Validation(Required=false)]
            public int? HighWarningCount { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The UUID of the server on which the baseline check is performed. Separate multiple UUIDs with commas (,).
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// Queries information about servers on which a baseline check is performed. The information includes the IDs of the servers, the statistics of a risk item, and the status of the risk item.
            /// </summary>
            [NameInMap("LowWarningCount")]
            [Validation(Required=false)]
            public int? LowWarningCount { get; set; }

            [NameInMap("MediumWarningCount")]
            [Validation(Required=false)]
            public int? MediumWarningCount { get; set; }

            [NameInMap("PassCount")]
            [Validation(Required=false)]
            public int? PassCount { get; set; }

            /// <summary>
            /// DescribeWarningMachines
            /// </summary>
            [NameInMap("PortOpen")]
            [Validation(Required=false)]
            public bool? PortOpen { get; set; }

            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether Security Center is authorized to protect the asset. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
