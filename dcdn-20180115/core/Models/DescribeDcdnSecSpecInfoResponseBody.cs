// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecSpecInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnSecSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnSecSpecInfoResponseBodySpecInfos : TeaModel {
            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            [NameInMap("RuleConfigs")]
            [Validation(Required=false)]
            public List<DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs> RuleConfigs { get; set; }
            public class DescribeDcdnSecSpecInfoResponseBodySpecInfosRuleConfigs : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
