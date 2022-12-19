// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotProbeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotProbeResponseBodyData Data { get; set; }
        public class GetHoneypotProbeResponseBodyData : TeaModel {
            [NameInMap("Arp")]
            [Validation(Required=false)]
            public bool? Arp { get; set; }

            [NameInMap("CanListenIpList")]
            [Validation(Required=false)]
            public List<string> CanListenIpList { get; set; }

            [NameInMap("CidrList")]
            [Validation(Required=false)]
            public List<string> CidrList { get; set; }

            [NameInMap("ControlNode")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataControlNode ControlNode { get; set; }
            public class GetHoneypotProbeResponseBodyDataControlNode : TeaModel {
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            [NameInMap("CpuLoad")]
            [Validation(Required=false)]
            public double? CpuLoad { get; set; }

            [NameInMap("DeployTime")]
            [Validation(Required=false)]
            public long? DeployTime { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("HoneyPotProbeScanPort")]
            [Validation(Required=false)]
            public GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort HoneyPotProbeScanPort { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneyPotProbeScanPort : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public string Ports { get; set; }

                [NameInMap("ProbeId")]
                [Validation(Required=false)]
                public string ProbeId { get; set; }

                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("HoneypotProbeBindList")]
            [Validation(Required=false)]
            public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindList> HoneypotProbeBindList { get; set; }
            public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindList : TeaModel {
                [NameInMap("BindId")]
                [Validation(Required=false)]
                public string BindId { get; set; }

                [NameInMap("BindPortList")]
                [Validation(Required=false)]
                public List<GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList> BindPortList { get; set; }
                public class GetHoneypotProbeResponseBodyDataHoneypotProbeBindListBindPortList : TeaModel {
                    [NameInMap("BindPort")]
                    [Validation(Required=false)]
                    public bool? BindPort { get; set; }

                    [NameInMap("EndPort")]
                    [Validation(Required=false)]
                    public int? EndPort { get; set; }

                    [NameInMap("Err")]
                    [Validation(Required=false)]
                    public string Err { get; set; }

                    [NameInMap("Fixed")]
                    [Validation(Required=false)]
                    public bool? Fixed { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    [NameInMap("Proto")]
                    [Validation(Required=false)]
                    public string Proto { get; set; }

                    [NameInMap("StartPort")]
                    [Validation(Required=false)]
                    public int? StartPort { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("TargetPort")]
                    [Validation(Required=false)]
                    public int? TargetPort { get; set; }

                }

                [NameInMap("HoneypotId")]
                [Validation(Required=false)]
                public string HoneypotId { get; set; }

                [NameInMap("ServiceIpList")]
                [Validation(Required=false)]
                public List<string> ServiceIpList { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("ListenIpList")]
            [Validation(Required=false)]
            public List<string> ListenIpList { get; set; }

            [NameInMap("MemoryLoad")]
            [Validation(Required=false)]
            public double? MemoryLoad { get; set; }

            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("Ping")]
            [Validation(Required=false)]
            public bool? Ping { get; set; }

            [NameInMap("ProbeId")]
            [Validation(Required=false)]
            public string ProbeId { get; set; }

            [NameInMap("ProbeType")]
            [Validation(Required=false)]
            public string ProbeType { get; set; }

            [NameInMap("ProbeVersion")]
            [Validation(Required=false)]
            public string ProbeVersion { get; set; }

            [NameInMap("ProxyIp")]
            [Validation(Required=false)]
            public string ProxyIp { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
