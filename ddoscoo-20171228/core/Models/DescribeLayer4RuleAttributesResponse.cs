// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer4RuleAttributesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Listeners")]
        [Validation(Required=true)]
        public List<DescribeLayer4RuleAttributesResponseListeners> Listeners { get; set; }
        public class DescribeLayer4RuleAttributesResponseListeners : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=true)]
            public int? FrontendPort { get; set; }

            [NameInMap("Config")]
            [Validation(Required=true)]
            public DescribeLayer4RuleAttributesResponseListenersConfig Config { get; set; }
            public class DescribeLayer4RuleAttributesResponseListenersConfig : TeaModel {
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=true)]
                public int? PersistenceTimeout { get; set; }
                [NameInMap("Synproxy")]
                [Validation(Required=true)]
                public string Synproxy { get; set; }
                [NameInMap("NodataConn")]
                [Validation(Required=true)]
                public string NodataConn { get; set; }
                [NameInMap("Sla")]
                [Validation(Required=true)]
                public DescribeLayer4RuleAttributesResponseListenersConfigSla Sla { get; set; }
                public class DescribeLayer4RuleAttributesResponseListenersConfigSla : TeaModel {
                    [NameInMap("Cps")]
                    [Validation(Required=true)]
                    public int? Cps { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=true)]
                    public int? Maxconn { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=true)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=true)]
                    public int? MaxconnEnable { get; set; }

                }
                [NameInMap("Slimit")]
                [Validation(Required=true)]
                public DescribeLayer4RuleAttributesResponseListenersConfigSlimit Slimit { get; set; }
                public class DescribeLayer4RuleAttributesResponseListenersConfigSlimit : TeaModel {
                    [NameInMap("Cps")]
                    [Validation(Required=true)]
                    public int? Cps { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=true)]
                    public int? Maxconn { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=true)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("CpsMode")]
                    [Validation(Required=true)]
                    public int? CpsMode { get; set; }

                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=true)]
                    public int? MaxconnEnable { get; set; }

                    [NameInMap("Bps")]
                    [Validation(Required=true)]
                    public long? Bps { get; set; }

                    [NameInMap("Pps")]
                    [Validation(Required=true)]
                    public long? Pps { get; set; }

                }
                [NameInMap("PayloadLen")]
                [Validation(Required=true)]
                public DescribeLayer4RuleAttributesResponseListenersConfigPayloadLen PayloadLen { get; set; }
                public class DescribeLayer4RuleAttributesResponseListenersConfigPayloadLen : TeaModel {
                    [NameInMap("Min")]
                    [Validation(Required=true)]
                    public int? Min { get; set; }

                    [NameInMap("Max")]
                    [Validation(Required=true)]
                    public int? Max { get; set; }

                }
                [NameInMap("Cc")]
                [Validation(Required=true)]
                public DescribeLayer4RuleAttributesResponseListenersConfigCc Cc { get; set; }
                public class DescribeLayer4RuleAttributesResponseListenersConfigCc : TeaModel {
                    [NameInMap("Sblack")]
                    [Validation(Required=true)]
                    public List<DescribeLayer4RuleAttributesResponseListenersConfigCcSblack> Sblack { get; set; }
                    public class DescribeLayer4RuleAttributesResponseListenersConfigCcSblack : TeaModel {
                        [NameInMap("During")]
                        [Validation(Required=true)]
                        public int? During { get; set; }

                        [NameInMap("Expires")]
                        [Validation(Required=true)]
                        public int? Expires { get; set; }

                        [NameInMap("Cnt")]
                        [Validation(Required=true)]
                        public int? Cnt { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=true)]
                        public int? Type { get; set; }

                    }

                }
            };

        }

    }

}
