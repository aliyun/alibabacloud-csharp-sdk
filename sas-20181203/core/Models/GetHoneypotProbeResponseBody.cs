// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotProbeResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code **200** indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details about the probe.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotProbeResponseBodyData Data { get; set; }
        public class GetHoneypotProbeResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether address resolution protocol (ARP) is enabled for the check type.
            /// </summary>
            [NameInMap("Arp")]
            [Validation(Required=false)]
            public bool? Arp { get; set; }

            /// <summary>
            /// An array consisting of the IP addresses that can be monitored.
            /// </summary>
            [NameInMap("CanListenIpList")]
            [Validation(Required=false)]
            public List<string> CanListenIpList { get; set; }

            /// <summary>
            /// An array consisting of the CIDR blocks that are allowed to access the VPC probe.
            /// </summary>
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<string> CidrList { get; set; }

            /// <summary>
            /// The information about the management node.
            /// </summary>
            [NameInMap("ControlNode")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataControlNode ControlNode { get; set; }
            public class GetHoneypotProbeResponseBodyDataControlNode : TeaModel {
                /// <summary>
                /// The instance ID of the management node.
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// The ID of the management node.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The name of the management node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// The CPU utilization.
            /// </summary>
            [NameInMap("CpuLoad")]
            [Validation(Required=false)]
            public double? CpuLoad { get; set; }

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
            /// The ports that the honeypot monitors.
            /// </summary>
            [NameInMap("HoneyPotProbeScanPort")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort HoneyPotProbeScanPort { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort : TeaModel {
                /// <summary>
                /// The ID of the monitoring record.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The ports that are monitored.
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public string Ports { get; set; }

                /// <summary>
                /// The ID of the probe.
                /// </summary>
                [NameInMap("ProbeId")]
                [Validation(Required=false)]
                public string ProbeId { get; set; }

                /// <summary>
                /// An array consisting of the IP addresses of the sever on which the probe is deployed.
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// The monitoring status. Valid values:
                /// 
                /// *   **1**: abnormal
                /// *   **3**: normal
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// An array consisting of the honeypots to which the probe forwards traffic.
            /// </summary>
            [NameInMap("HoneypotProbeBindList")]
            [Validation(Required=false)]
            public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindList> HoneypotProbeBindList { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindList : TeaModel {
                /// <summary>
                /// The ID of the binding record.
                /// </summary>
                [NameInMap("BindId")]
                [Validation(Required=false)]
                public string BindId { get; set; }

                /// <summary>
                /// An array consisting of the ports that are bound to the probe.
                /// </summary>
                [NameInMap("BindPortList")]
                [Validation(Required=false)]
                public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList> BindPortList { get; set; }
                public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList : TeaModel {
                    /// <summary>
                    /// Indicates whether the port is bound.
                    /// </summary>
                    [NameInMap("BindPort")]
                    [Validation(Required=false)]
                    public bool? BindPort { get; set; }

                    /// <summary>
                    /// The end port on which the probe monitors.
                    /// </summary>
                    [NameInMap("EndPort")]
                    [Validation(Required=false)]
                    public int? EndPort { get; set; }

                    /// <summary>
                    /// The error that indicates a binding failure.
                    /// </summary>
                    [NameInMap("Err")]
                    [Validation(Required=false)]
                    public string Err { get; set; }

                    /// <summary>
                    /// Indicates whether the port is a fixed port.
                    /// </summary>
                    [NameInMap("Fixed")]
                    [Validation(Required=false)]
                    public bool? Fixed { get; set; }

                    /// <summary>
                    /// The ID of the port binding record.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The details about the error.
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// The protocol type.
                    /// </summary>
                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    /// <summary>
                    /// The start port on which the probe monitors.
                    /// </summary>
                    [NameInMap("StartPort")]
                    [Validation(Required=false)]
                    public int? StartPort { get; set; }

                    /// <summary>
                    /// The binding status. Valid values:
                    /// 
                    /// *   **1**: abnormal
                    /// *   **3**: normal
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// The destination port.
                    /// </summary>
                    [NameInMap("TargetPort")]
                    [Validation(Required=false)]
                    public int? TargetPort { get; set; }

                }

                /// <summary>
                /// The ID of the honeypot.
                /// </summary>
                [NameInMap("HoneypotId")]
                [Validation(Required=false)]
                public string HoneypotId { get; set; }

                /// <summary>
                /// An array consisting of the IP addresses that are monitored.
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// The status of the service. Valid values:
                /// 
                /// *   **1**: abnormal
                /// *   **3**: normal
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The IP address of the server on which the probe is deployed.
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// An array consisting of the IP addresses that can be monitored.
            /// </summary>
            [NameInMap("ListenIpList")]
            [Validation(Required=false)]
            public List<string> ListenIpList { get; set; }

            /// <summary>
            /// The memory usage.
            /// </summary>
            [NameInMap("MemoryLoad")]
            [Validation(Required=false)]
            public double? MemoryLoad { get; set; }

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
            /// Indicates whether ping is enabled for the check type.
            /// </summary>
            [NameInMap("Ping")]
            [Validation(Required=false)]
            public bool? Ping { get; set; }

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
            /// *   **vpc_black_hole_probe**: virtual private cloud (VPC) probe
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
            /// The IP address of the proxy server.
            /// </summary>
            [NameInMap("ProxyIp")]
            [Validation(Required=false)]
            public string ProxyIp { get; set; }

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
            public int? Status { get; set; }

            /// <summary>
            /// The UUID of the asset on which the host probe is deployed.
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
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
