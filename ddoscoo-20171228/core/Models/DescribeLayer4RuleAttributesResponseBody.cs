// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer4RuleAttributesResponseBody : TeaModel {
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeLayer4RuleAttributesResponseBodyListeners> Listeners { get; set; }
        public class DescribeLayer4RuleAttributesResponseBodyListeners : TeaModel {
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeLayer4RuleAttributesResponseBodyListenersConfig Config { get; set; }
            public class DescribeLayer4RuleAttributesResponseBodyListenersConfig : TeaModel {
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigCc Cc { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigCc : TeaModel {
                    [NameInMap("Sblack")]
                    [Validation(Required=false)]
                    public List<DescribeLayer4RuleAttributesResponseBodyListenersConfigCcSblack> Sblack { get; set; }
                    public class DescribeLayer4RuleAttributesResponseBodyListenersConfigCcSblack : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                    }

                }
                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigPayloadLen PayloadLen { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigPayloadLen : TeaModel {
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }
                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigSla Sla { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigSla : TeaModel {
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                }
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigSlimit Slimit { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigSlimit : TeaModel {
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                }
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }
                [NameInMap("Synproxy")]
                [Validation(Required=false)]
                public string Synproxy { get; set; }
            };

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
