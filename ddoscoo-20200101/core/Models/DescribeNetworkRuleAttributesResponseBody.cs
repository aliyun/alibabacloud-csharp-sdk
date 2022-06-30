// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRuleAttributesResponseBody : TeaModel {
        [NameInMap("NetworkRuleAttributes")]
        [Validation(Required=false)]
        public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes> NetworkRuleAttributes { get; set; }
        public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributes : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig Config { get; set; }
            public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfig : TeaModel {
                [NameInMap("Cc")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc Cc { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCc : TeaModel {
                    [NameInMap("Sblack")]
                    [Validation(Required=false)]
                    public List<DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack> Sblack { get; set; }
                    public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigCcSblack : TeaModel {
                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                }
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }
                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen PayloadLen { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigPayloadLen : TeaModel {
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
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla Sla { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSla : TeaModel {
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                }
                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit Slimit { get; set; }
                public class DescribeNetworkRuleAttributesResponseBodyNetworkRuleAttributesConfigSlimit : TeaModel {
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                }
                [NameInMap("Synproxy")]
                [Validation(Required=false)]
                public string Synproxy { get; set; }
            };

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
