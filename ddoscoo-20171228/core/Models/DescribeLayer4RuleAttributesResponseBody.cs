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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Cnt")]
                        [Validation(Required=false)]
                        public int? Cnt { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("During")]
                        [Validation(Required=false)]
                        public int? During { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1800</para>
                        /// </summary>
                        [NameInMap("Expires")]
                        [Validation(Required=false)]
                        public int? Expires { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("NodataConn")]
                [Validation(Required=false)]
                public string NodataConn { get; set; }

                [NameInMap("PayloadLen")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigPayloadLen PayloadLen { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigPayloadLen : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public int? Max { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }

                [NameInMap("Sla")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigSla Sla { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigSla : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                }

                [NameInMap("Slimit")]
                [Validation(Required=false)]
                public DescribeLayer4RuleAttributesResponseBodyListenersConfigSlimit Slimit { get; set; }
                public class DescribeLayer4RuleAttributesResponseBodyListenersConfigSlimit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Bps")]
                    [Validation(Required=false)]
                    public long? Bps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Cps")]
                    [Validation(Required=false)]
                    public int? Cps { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CpsEnable")]
                    [Validation(Required=false)]
                    public int? CpsEnable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("CpsMode")]
                    [Validation(Required=false)]
                    public int? CpsMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Maxconn")]
                    [Validation(Required=false)]
                    public int? Maxconn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxconnEnable")]
                    [Validation(Required=false)]
                    public int? MaxconnEnable { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Pps")]
                    [Validation(Required=false)]
                    public long? Pps { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("Synproxy")]
                [Validation(Required=false)]
                public string Synproxy { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-XXXXX</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CF33B4C3-196E-4015-AADD-5CAD00057B80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
