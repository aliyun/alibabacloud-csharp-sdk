// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecSpecInfoResponseBody : TeaModel {
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
        public List<DescribeDcdnSecSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnSecSpecInfoResponseBodySpecInfos : TeaModel {
            /// <summary>
            /// The code of the security rule.
            /// </summary>
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// The configurations of the security rule.
            /// </summary>
            [NameInMap("RuleConfigs")]
            [Validation(Required=false)]
            public List<DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs> RuleConfigs { get; set; }
            public class DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs : TeaModel {
                /// <summary>
                /// The configuration code of the security rule.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The configuration expression of the security rule.
                /// </summary>
                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                /// <summary>
                /// The value of the configuration expression of the security rule.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The version of secure DCDN.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
