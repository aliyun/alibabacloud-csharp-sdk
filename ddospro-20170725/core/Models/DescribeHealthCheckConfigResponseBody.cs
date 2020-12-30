// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribeHealthCheckConfigResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeHealthCheckConfigResponseBodyListeners> Listeners { get; set; }
        public class DescribeHealthCheckConfigResponseBodyListeners : TeaModel {
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("Check")]
            [Validation(Required=false)]
            public DescribeHealthCheckConfigResponseBodyListenersCheck Check { get; set; }
            public class DescribeHealthCheckConfigResponseBodyListenersCheck : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }
                [NameInMap("Up")]
                [Validation(Required=false)]
                public int? Up { get; set; }
                [NameInMap("Down")]
                [Validation(Required=false)]
                public int? Down { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }
            };

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("BackPort")]
            [Validation(Required=false)]
            public int? BackPort { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeHealthCheckConfigResponseBodyListenersConfig Config { get; set; }
            public class DescribeHealthCheckConfigResponseBodyListenersConfig : TeaModel {
                [NameInMap("SynProxy")]
                [Validation(Required=false)]
                public string SynProxy { get; set; }
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }
                [NameInMap("NoDataConn")]
                [Validation(Required=false)]
                public string NoDataConn { get; set; }
                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeHealthCheckConfigResponseBodyListenersConfigSla Sla { get; set; }
                public class DescribeHealthCheckConfigResponseBodyListenersConfigSla : TeaModel {
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("MaxConnEnable")]
                    [Validation(Required=false)]
                    public int? MaxConnEnable { get; set; }

                    [NameInMap("MaxConn")]
                    [Validation(Required=false)]
                    public int? MaxConn { get; set; }

                }
                [NameInMap("PayloadLength")]
                [Validation(Required=false)]
                public DescribeHealthCheckConfigResponseBodyListenersConfigPayloadLength PayloadLength { get; set; }
                public class DescribeHealthCheckConfigResponseBodyListenersConfigPayloadLength : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeHealthCheckConfigResponseBodyListenersConfigSlimit Slimit { get; set; }
                public class DescribeHealthCheckConfigResponseBodyListenersConfigSlimit : TeaModel {
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("MaxConnEnable")]
                    [Validation(Required=false)]
                    public int? MaxConnEnable { get; set; }

                    [NameInMap("MaxConn")]
                    [Validation(Required=false)]
                    public int? MaxConn { get; set; }

                }
            };

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
