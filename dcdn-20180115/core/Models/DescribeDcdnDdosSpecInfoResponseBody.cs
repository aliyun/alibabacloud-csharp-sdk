// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDdosSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth limit of a single instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40Gbps</para>
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public string BandwidthLimit { get; set; }

        /// <summary>
        /// <para>The version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>poc</b>: POC Edition</description></item>
        /// <item><description><b>basic</b>: Basic Edition</description></item>
        /// <item><description><b>insurance</b>: Insurance Edition</description></item>
        /// <item><description><b>unlimited</b>: Unlimited Edition</description></item>
        /// <item><description><b>port_enhancement</b>: Special Port Enhanced Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>insurance</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable DDoS mitigation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on:</b></description></item>
        /// <item><description><b>off</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>Specifies whether custom ports are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b></description></item>
        /// <item><description><b>no</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("IsSpecialPort")]
        [Validation(Required=false)]
        public string IsSpecialPort { get; set; }

        /// <summary>
        /// <para>Protected region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>global</b>: global</description></item>
        /// <item><description><b>chinese_mainland</b>: Chinese mainland</description></item>
        /// <item><description><b>global_excluding_the_chinese_mainland</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("ProtectedArea")]
        [Validation(Required=false)]
        public string ProtectedArea { get; set; }

        /// <summary>
        /// <para>The QPS limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("QpsLimit")]
        [Validation(Required=false)]
        public string QpsLimit { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEA8E7BE-33C6-56F5-AC56-74D50547CF34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The code and configurations of the security rules.</para>
        /// </summary>
        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnDdosSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// <para>The configurations of the version rule.</para>
            /// </summary>
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration code of the version rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>total_defense_num</b>: the total number of mitigation sessions of the version.</description></item>
                /// <item><description><b>consume_defense_num</b>: the number of used mitigation sessions of the version.</description></item>
                /// <item><description><b>max_domain_num</b>: the limit on the number of added domain names.</description></item>
                /// <item><description><b>emain_domain_num</b>: the number of added domain names.</description></item>
                /// <item><description><b>defence_package_num</b>: the total number of purchased additional mitigation sessions.</description></item>
                /// <item><description><b>consume_defence_package_num</b>: the number of used additional mitigation sessions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>total_defense_num</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The configuration expression of the version rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>equal</para>
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// <para>The value of the configuration expression of the version rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The version rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>version_defense_num</b>: the rule for the number of version mitigation sessions</description></item>
            /// <item><description><b>domain_num</b>: the rule for the limit on the number of domain names</description></item>
            /// <item><description><b>defence_package_num</b>: the rule for extra mitigation session plans</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>version_defense_num</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

        }

    }

}
