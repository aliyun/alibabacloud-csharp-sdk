// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafSpecInfoResponseBody : TeaModel {
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnWafSpecInfoResponseBodySpecInfos : TeaModel {
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnWafSpecInfoResponseBodySpecInfosConfigs : TeaModel {
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("Expr")]
                [Validation(Required=false)]
                public string Expr { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

        }

    }

}
