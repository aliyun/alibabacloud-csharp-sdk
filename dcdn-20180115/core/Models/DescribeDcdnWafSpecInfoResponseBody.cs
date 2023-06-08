// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafSpecInfoResponseBody : TeaModel {
        /// <summary>
        /// The version of WAF.
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported types of protection policies and the configuration information of protection rules.
        /// </summary>
        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnWafSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// The configuration information of the protection rule.
            /// </summary>
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs : TeaModel {
                /// <summary>
                /// The configuration code of the protection rule.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The configuration expression of the protection rule.
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// The value of the configuration expression of the protection rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The type of the protection policy. Valid values:
            /// 
            /// *   waf_group: basic web protection
            /// *   custom_acl: custom
            /// *   whitelist: whitelist
            /// *   ip_blacklist: IP address blacklist
            /// *   region_block: region blacklist
            /// *   bot: bot management
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

        }

    }

}
