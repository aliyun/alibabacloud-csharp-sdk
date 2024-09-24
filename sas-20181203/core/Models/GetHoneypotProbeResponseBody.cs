// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotProbeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code <b>200</b> indicates that the request was successful. Other status codes indicate that the request failed. You can identify the cause of the failure based on the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the probe.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotProbeResponseBodyData Data { get; set; }
        public class GetHoneypotProbeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether address resolution protocol (ARP) is enabled for the check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Arp")]
            [Validation(Required=false)]
            public bool? Arp { get; set; }

            /// <summary>
            /// <para>An array consisting of the IP addresses that can be monitored.</para>
            /// </summary>
            [NameInMap("CanListenIpList")]
            [Validation(Required=false)]
            public List<string> CanListenIpList { get; set; }

            /// <summary>
            /// <para>The CIDR blocks of the probe deployed in a virtual private cloud (VPC).</para>
            /// </summary>
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<string> CidrList { get; set; }

            /// <summary>
            /// <para>The information about the management node.</para>
            /// </summary>
            [NameInMap("ControlNode")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataControlNode ControlNode { get; set; }
            public class GetHoneypotProbeResponseBodyDataControlNode : TeaModel {
                /// <summary>
                /// <para>The instance ID of the management node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp19ijepxytwtzrk****</para>
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the management node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37a15ff1-3475-4897-aa6c-f7fd9122****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The name of the management node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online-honeypot</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>The CPU utilization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.51</para>
            /// </summary>
            [NameInMap("CpuLoad")]
            [Validation(Required=false)]
            public double? CpuLoad { get; set; }

            /// <summary>
            /// <para>The time when the probe was deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669363825000</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public long? DeployTime { get; set; }

            /// <summary>
            /// <para>The name of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-probe</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ports that the honeypot monitors.</para>
            /// </summary>
            [NameInMap("HoneyPotProbeScanPort")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort HoneyPotProbeScanPort { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort : TeaModel {
                /// <summary>
                /// <para>The unique ID of the service that is monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15389</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ports that are monitored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;tcp&quot;: &quot;1-65535&quot;,
                ///     &quot;udp&quot;: &quot;1-65535&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Ports")]
                [Validation(Required=false)]
                public string Ports { get; set; }

                /// <summary>
                /// <para>The ID of the probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a46f5162-c70d-4e26-8ddf-7435feca****</para>
                /// </summary>
                [NameInMap("ProbeId")]
                [Validation(Required=false)]
                public string ProbeId { get; set; }

                /// <summary>
                /// <para>The IP addresses that are monitored.</para>
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// <para>The monitoring status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: abnormal</description></item>
                /// <item><description><b>3</b>: normal</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The honeypots that are bound to the probe.</para>
            /// </summary>
            [NameInMap("HoneypotProbeBindList")]
            [Validation(Required=false)]
            public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindList> HoneypotProbeBindList { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindList : TeaModel {
                /// <summary>
                /// <para>The unique ID of the honeypot that is bound to the probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45378f64-d7b4-4a53-9c48-4303eb4b****</para>
                /// </summary>
                [NameInMap("BindId")]
                [Validation(Required=false)]
                public string BindId { get; set; }

                /// <summary>
                /// <para>The ports that are bound to the probe.</para>
                /// </summary>
                [NameInMap("BindPortList")]
                [Validation(Required=false)]
                public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList> BindPortList { get; set; }
                public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the port is bound.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BindPort")]
                    [Validation(Required=false)]
                    public bool? BindPort { get; set; }

                    /// <summary>
                    /// <para>The end port on which the probe monitors.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("EndPort")]
                    [Validation(Required=false)]
                    public int? EndPort { get; set; }

                    /// <summary>
                    /// <para>The error that is returned if an error occurred in the port of the honeypot that is bound to the probe.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>portmap failed</para>
                    /// </summary>
                    [NameInMap("Err")]
                    [Validation(Required=false)]
                    public string Err { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the port is a fixed port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Fixed")]
                    [Validation(Required=false)]
                    public bool? Fixed { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the port binding record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2512</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The error message that is returned if an error occurred in the port of the honeypot that is bound to the probe.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>listen 22 tcp4 failed</para>
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// <para>The type of the protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tcp</para>
                    /// </summary>
                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    /// <summary>
                    /// <para>The start port on which the probe monitors.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("StartPort")]
                    [Validation(Required=false)]
                    public int? StartPort { get; set; }

                    /// <summary>
                    /// <para>The status of the port of the honeypot that is bound to the probe. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: abnormal</description></item>
                    /// <item><description><b>3</b>: normal</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The destination port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("TargetPort")]
                    [Validation(Required=false)]
                    public int? TargetPort { get; set; }

                }

                /// <summary>
                /// <para>The honeypot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>913347774a3b3c378c6a50f66de23dfa097765214ec3f0526b01c67bf59c****</para>
                /// </summary>
                [NameInMap("HoneypotId")]
                [Validation(Required=false)]
                public string HoneypotId { get; set; }

                /// <summary>
                /// <para>The IP addresses that are monitored.</para>
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// <para>The status of the honeypot that is bound to the probe. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: abnormal</description></item>
                /// <item><description><b>3</b>: normal</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <para>The IP address of the server on which the probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33.53.XX.XX</para>
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// <para>An array consisting of the IP addresses that can be monitored.</para>
            /// </summary>
            [NameInMap("ListenIpList")]
            [Validation(Required=false)]
            public List<string> ListenIpList { get; set; }

            /// <summary>
            /// <para>The memory usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.94</para>
            /// </summary>
            [NameInMap("MemoryLoad")]
            [Validation(Required=false)]
            public double? MemoryLoad { get; set; }

            /// <summary>
            /// <para>The operating system of the server on which the probe is deployed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows</description></item>
            /// <item><description>linux</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>Indicates whether ping is enabled for the check type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ping")]
            [Validation(Required=false)]
            public bool? Ping { get; set; }

            /// <summary>
            /// <para>The ID of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40f6501d-45ec-4bf0-b813-0072ceb4****</para>
            /// </summary>
            [NameInMap("ProbeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            /// <summary>
            /// <para>The type of the probe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host_probe</b>: host probe</description></item>
            /// <item><description><b>vpc_black_hole_probe</b>: virtual private cloud (VPC) probe</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>host_probe</para>
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// <para>The version of the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18060096</para>
            /// </summary>
            [NameInMap("ProbeVersion")]
            [Validation(Required=false)]
            public string ProbeVersion { get; set; }

            /// <summary>
            /// <para>The IP address of the proxy server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.108.XX.XX</para>
            /// </summary>
            [NameInMap("ProxyIp")]
            [Validation(Required=false)]
            public string ProxyIp { get; set; }

            /// <summary>
            /// <para>The status of the probe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>installed</b>: installed</description></item>
            /// <item><description><b>install_failed</b>: installation failed</description></item>
            /// <item><description><b>online</b>: online</description></item>
            /// <item><description><b>offline</b>: offline</description></item>
            /// <item><description><b>unnormal</b>: abnormal</description></item>
            /// <item><description><b>unprobe</b>: unauthorized</description></item>
            /// <item><description><b>uninstalling</b>: being uninstalled</description></item>
            /// <item><description><b>uninstalled</b>: uninstalled</description></item>
            /// <item><description><b>uninstall_failed</b>: uninstallation failed</description></item>
            /// <item><description><b>not_exist</b>: not installed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset on which the host probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the VPC in which the probe is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vchkxmf2j9yjt3x2****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6550E0E6-FD6C-5F39-AB5E-35B30DCA97B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
