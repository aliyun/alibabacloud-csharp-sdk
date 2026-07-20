// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteTrafficSequenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The traffic sequences of the site.</para>
        /// </summary>
        [NameInMap("TrafficSequences")]
        [Validation(Required=false)]
        public List<GetSiteTrafficSequenceResponseBodyTrafficSequences> TrafficSequences { get; set; }
        public class GetSiteTrafficSequenceResponseBodyTrafficSequences : TeaModel {
            /// <summary>
            /// <para>The list of site features associated with the traffic sequence.</para>
            /// </summary>
            [NameInMap("FunctionList")]
            [Validation(Required=false)]
            public List<GetSiteTrafficSequenceResponseBodyTrafficSequencesFunctionList> FunctionList { get; set; }
            public class GetSiteTrafficSequenceResponseBodyTrafficSequencesFunctionList : TeaModel {
                /// <summary>
                /// <para>The list of configurations for the site feature associated with the traffic sequence.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Configs")]
                [Validation(Required=false)]
                public List<GetSiteTrafficSequenceResponseBodyTrafficSequencesFunctionListConfigs> Configs { get; set; }
                public class GetSiteTrafficSequenceResponseBodyTrafficSequencesFunctionListConfigs : TeaModel {
                    /// <summary>
                    /// <para>The configuration ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>480339095269376</para>
                    /// </summary>
                    [NameInMap("ConfigId")]
                    [Validation(Required=false)]
                    public long? ConfigId { get; set; }

                    /// <summary>
                    /// <para>The configuration type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>global: global configuration.</description></item>
                    /// <item><description>rule: rule configuration.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>global</para>
                    /// </summary>
                    [NameInMap("ConfigType")]
                    [Validation(Required=false)]
                    public string ConfigType { get; set; }

                }

                /// <summary>
                /// <para>The feature name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redirect_rules</para>
                /// </summary>
                [NameInMap("FunctionName")]
                [Validation(Required=false)]
                public string FunctionName { get; set; }

                /// <summary>
                /// <para>Indicates whether the site has a corresponding configuration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The site has a corresponding configuration.</description></item>
                /// <item><description>false: The site does not have a corresponding configuration.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasConfig")]
                [Validation(Required=false)]
                public bool? HasConfig { get; set; }

            }

            /// <summary>
            /// <para>The order of the current sequence in the entire traffic sequence.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

            /// <summary>
            /// <para>The traffic sequence routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/safe/ddos/basic</para>
            /// </summary>
            [NameInMap("Router")]
            [Validation(Required=false)]
            public string Router { get; set; }

            /// <summary>
            /// <para>The sequence code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddos</para>
            /// </summary>
            [NameInMap("SequenceCode")]
            [Validation(Required=false)]
            public string SequenceCode { get; set; }

            /// <summary>
            /// <para>The sequence name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DDOS</para>
            /// </summary>
            [NameInMap("SequenceName")]
            [Validation(Required=false)]
            public string SequenceName { get; set; }

        }

    }

}
