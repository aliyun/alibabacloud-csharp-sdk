// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDdosSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// The bandwidth limit of a single instance.
        /// </summary>
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public string BandwidthLimit { get; set; }

        /// <summary>
        /// The version. Valid values:
        /// 
        /// * **poc**: POC Edition
        /// * **basic**: Basic Edition
        /// * **insurance**: Insurance Edition
        /// * **unlimited**: Unlimited Edition
        /// * **port_enhancement**: Special Port Enhanced Edition
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// Specifies whether to enable DDoS mitigation. Valid values:
        /// 
        /// *   **on:**
        /// *   **off**.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// Specifies whether custom ports are supported. Valid values:
        /// 
        /// *   **yes**
        /// *   **no**
        /// </summary>
        [NameInMap("IsSpecialPort")]
        [Validation(Required=false)]
        public string IsSpecialPort { get; set; }

        /// <summary>
        /// Protected region. Valid values:
        /// 
        /// * **global**: global
        /// * **chinese_mainland**: Chinese mainland
        /// * **global_excluding_the_chinese_mainland**: outside the Chinese mainland
        /// </summary>
        [NameInMap("ProtectedArea")]
        [Validation(Required=false)]
        public string ProtectedArea { get; set; }

        /// <summary>
        /// The QPS limit.
        /// </summary>
        [NameInMap("QpsLimit")]
        [Validation(Required=false)]
        public string QpsLimit { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The code and configurations of the security rules.
        /// </summary>
        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnDdosSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// The configurations of the version rule.
            /// </summary>
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs : TeaModel {
                /// <summary>
                /// The configuration code of the version rule. Valid values:
                /// 
                /// *   **total_defense_num**: the total number of mitigation sessions of the version.
                /// *   **consume_defense_num**: the number of used mitigation sessions of the version.
                /// *   **max_domain_num**: the limit on the number of added domain names.
                /// *   **emain_domain_num**: the number of added domain names.
                /// *   **defence_package_num**: the total number of purchased additional mitigation sessions.
                /// *   **consume_defence_package_num**: the number of used additional mitigation sessions.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The configuration expression of the version rule.
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// The value of the configuration expression of the version rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The version rule. Valid values:
            /// 
            /// *   **version_defense_num**: the rule for the number of version mitigation sessions
            /// *   **domain_num**: the rule for the limit on the number of domain names
            /// *   **defence_package_num**: the rule for extra mitigation session plans
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

        }

    }

}
