// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotProbeResponseBody : TeaModel {
        /// <summary>
        /// The status code that is returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// An array that consists of the details about the probe.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListHoneypotProbeResponseBodyList> List { get; set; }
        public class ListHoneypotProbeResponseBodyList : TeaModel {
            /// <summary>
            /// The information about the management node.
            /// </summary>
            [NameInMap("ControlNode")]
            [Validation(Required=false)]
            public ListHoneypotProbeResponseBodyListControlNode ControlNode { get; set; }
            public class ListHoneypotProbeResponseBodyListControlNode : TeaModel {
                /// <summary>
                /// The ID of the Elastic Compute Service (ECS) instance.
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// The time when the probe was deployed.
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public long? DeployTime { get; set; }

            /// <summary>
            /// The name of the probe.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The IP address of the server on which the probe is installed.
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// The operating system of the server on which the probe is deployed. Valid values:
            /// 
            /// *   windows
            /// *   linux
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The ID of the probe.
            /// </summary>
            [NameInMap("ProbeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            /// <summary>
            /// The type of the probe. Valid values:
            /// 
            /// *   **host_probe**: host probe
            /// *   **vpc_black_hole_probe**: VPC probe
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// The version of the probe.
            /// </summary>
            [NameInMap("ProbeVersion")]
            [Validation(Required=false)]
            public string ProbeVersion { get; set; }

            /// <summary>
            /// The status of the probe. Valid values:
            /// 
            /// *   **installed**: installed
            /// *   **install_failed**: installation failed
            /// *   **online**: online
            /// *   **offline**: offline
            /// *   **unnormal**: abnormal
            /// *   **unprobe**: unauthorized
            /// *   **uninstalling**: being uninstalled
            /// *   **uninstalled**: uninstalled
            /// *   **uninstall_failed**: uninstallation failed
            /// *   **not_exist**: not installed
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The UUID of the server to which the host probe is deployed.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The ID of the VPC in which the VPC probe is deployed.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotProbeResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotProbeResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
