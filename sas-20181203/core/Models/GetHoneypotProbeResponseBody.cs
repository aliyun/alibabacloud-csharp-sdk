// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotProbeResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success, whereas any other value indicates failure. You can use this field to identify the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The probe data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotProbeResponseBodyData Data { get; set; }
        public class GetHoneypotProbeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ARP check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Arp")]
            [Validation(Required=false)]
            public bool? Arp { get; set; }

            /// <summary>
            /// <para>The list of listenable IP addresses.</para>
            /// </summary>
            [NameInMap("CanListenIpList")]
            [Validation(Required=false)]
            public List<string> CanListenIpList { get; set; }

            /// <summary>
            /// <para>The list of CIDR blocks covered by the VPC probe.</para>
            /// </summary>
            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<string> CidrList { get; set; }

            /// <summary>
            /// <para>The management node.</para>
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
                /// <para>The management node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37a15ff1-3475-4897-aa6c-f7fd9122****</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The management node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>online-honeypot</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>The CPU usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.51</para>
            /// </summary>
            [NameInMap("CpuLoad")]
            [Validation(Required=false)]
            public double? CpuLoad { get; set; }

            /// <summary>
            /// <para>The deployment time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669363825000</para>
            /// </summary>
            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public long? DeployTime { get; set; }

            /// <summary>
            /// <para>The probe name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-probe</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The list of honeypot listening port scanning services.</para>
            /// </summary>
            [NameInMap("HoneyPotProbeScanPort")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort HoneyPotProbeScanPort { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort : TeaModel {
                /// <summary>
                /// <para>The unique ID of the listening service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15389</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The listening ports.</para>
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
                /// <para>The unique ID of the probe.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a46f5162-c70d-4e26-8ddf-7435feca****</para>
                /// </summary>
                [NameInMap("ProbeId")]
                [Validation(Required=false)]
                public string ProbeId { get; set; }

                /// <summary>
                /// <para>The list of listening IP addresses.</para>
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// <para>The status of the listening service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Service exception.</description></item>
                /// <item><description><b>3</b>: Normal.</description></item>
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
            /// <para>The list of honeypot services bound to the probe.</para>
            /// </summary>
            [NameInMap("HoneypotProbeBindList")]
            [Validation(Required=false)]
            public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindList> HoneypotProbeBindList { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindList : TeaModel {
                /// <summary>
                /// <para>The unique ID of the bound service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45378f64-d7b4-4a53-9c48-4303eb4b****</para>
                /// </summary>
                [NameInMap("BindId")]
                [Validation(Required=false)]
                public string BindId { get; set; }

                /// <summary>
                /// <para>The list of bound ports.</para>
                /// </summary>
                [NameInMap("BindPortList")]
                [Validation(Required=false)]
                public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList> BindPortList { get; set; }
                public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether the port is bound.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("BindPort")]
                    [Validation(Required=false)]
                    public bool? BindPort { get; set; }

                    /// <summary>
                    /// <para>The ending listening port of the probe.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("EndPort")]
                    [Validation(Required=false)]
                    public int? EndPort { get; set; }

                    /// <summary>
                    /// <para>The bound service port error.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>portmap failed</para>
                    /// </summary>
                    [NameInMap("Err")]
                    [Validation(Required=false)]
                    public string Err { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the port is fixed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Fixed")]
                    [Validation(Required=false)]
                    public bool? Fixed { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the bound port record.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2512</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The error details of the bound service port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>listen 22 tcp4 failed</para>
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// <para>The protocol type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tcp</para>
                    /// </summary>
                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    /// <summary>
                    /// <para>The starting listening port of the probe.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22</para>
                    /// </summary>
                    [NameInMap("StartPort")]
                    [Validation(Required=false)]
                    public int? StartPort { get; set; }

                    /// <summary>
                    /// <para>The status of the bound service port. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: Service exception.</description></item>
                    /// <item><description><b>3</b>: Normal.</description></item>
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
                /// <para>The list of listening IP addresses.</para>
                /// </summary>
                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                /// <summary>
                /// <para>The status of the bound honeypot service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Service exception.</description></item>
                /// <item><description><b>3</b>: Normal.</description></item>
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
            /// <para>The local address bound to the probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>33.53.XX.XX</para>
            /// </summary>
            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            /// <summary>
            /// <para>The list of listenable IP addresses.</para>
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
            /// <para>The operating system type of the probe instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>windows: Windows.</description></item>
            /// <item><description>linux: Linux.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The ping check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ping")]
            [Validation(Required=false)]
            public bool? Ping { get; set; }

            /// <summary>
            /// <para>The probe ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40f6501d-45ec-4bf0-b813-0072ceb4****</para>
            /// </summary>
            [NameInMap("ProbeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            /// <summary>
            /// <para>The probe type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>host_probe</b>: Host probe.</description></item>
            /// <item><description><b>vpc_black_hole_probe</b>: VPC blackhole probe.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>host_probe</para>
            /// </summary>
            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            /// <summary>
            /// <para>The probe version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18060096</para>
            /// </summary>
            [NameInMap("ProbeVersion")]
            [Validation(Required=false)]
            public string ProbeVersion { get; set; }

            /// <summary>
            /// <para>The proxy IP address deployed in the IDC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.108.XX.XX</para>
            /// </summary>
            [NameInMap("ProxyIp")]
            [Validation(Required=false)]
            public string ProxyIp { get; set; }

            /// <summary>
            /// <para>The probe status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>installed</b>: Installed successfully.</description></item>
            /// <item><description><b>install_failed</b>: Installation failed.</description></item>
            /// <item><description><b>online</b>: Normal.</description></item>
            /// <item><description><b>offline</b>: Offline.</description></item>
            /// <item><description><b>unnormal</b>: Service exception.</description></item>
            /// <item><description><b>unprobe</b>: Unauthorized.</description></item>
            /// <item><description><b>uninstalling</b>: Uninstalling.</description></item>
            /// <item><description><b>uninstalled</b>: Uninstalled successfully.</description></item>
            /// <item><description><b>uninstall_failed</b>: Uninstallation failed.</description></item>
            /// <item><description><b>not_exist</b>: Not installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The UUID of the asset instance where the host probe is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6690a46c-0edb-4663-a641-3629d1a9****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the VPC-connected instance where the VPC probe is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vchkxmf2j9yjt3x2****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message returned by the API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. It is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6550E0E6-FD6C-5F39-AB5E-35B30DCA97B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The API call is successful.</description></item>
        /// <item><description><b>false</b>: The API call failed.</description></item>
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
