// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class Probe : TeaModel {
        [NameInMap("failureThreshold")]
        [Validation(Required=false)]
        public int? FailureThreshold { get; set; }

        [NameInMap("initialDelaySeconds")]
        [Validation(Required=false)]
        public int? InitialDelaySeconds { get; set; }

        [NameInMap("periodSeconds")]
        [Validation(Required=false)]
        public int? PeriodSeconds { get; set; }

        [NameInMap("probeHandler")]
        [Validation(Required=false)]
        public ProbeProbeHandler ProbeHandler { get; set; }
        public class ProbeProbeHandler : TeaModel {
            [NameInMap("httpGet")]
            [Validation(Required=false)]
            public ProbeProbeHandlerHttpGet HttpGet { get; set; }
            public class ProbeProbeHandlerHttpGet : TeaModel {
                [NameInMap("httpHeaders")]
                [Validation(Required=false)]
                public List<ProbeProbeHandlerHttpGetHttpHeaders> HttpHeaders { get; set; }
                public class ProbeProbeHandlerHttpGetHttpHeaders : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            [NameInMap("tcpSocket")]
            [Validation(Required=false)]
            public ProbeProbeHandlerTcpSocket TcpSocket { get; set; }
            public class ProbeProbeHandlerTcpSocket : TeaModel {
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

        }

        [NameInMap("timeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
