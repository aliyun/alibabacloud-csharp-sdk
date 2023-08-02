// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDdosSpecInfoResponseBody : TeaModel {
        [NameInMap("BandwidthLimit")]
        [Validation(Required=false)]
        public string BandwidthLimit { get; set; }

        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        [NameInMap("ProtectedArea")]
        [Validation(Required=false)]
        public string ProtectedArea { get; set; }

        [NameInMap("QpsLimit")]
        [Validation(Required=false)]
        public string QpsLimit { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecInfos")]
        [Validation(Required=false)]
        public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfos> SpecInfos { get; set; }
        public class DescribeDcdnDdosSpecInfoResponseBodySpecInfos : TeaModel {
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public List<DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs> Configs { get; set; }
            public class DescribeDcdnDdosSpecInfoResponseBodySpecInfosConfigs : TeaModel {
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

            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

        }

    }

}
