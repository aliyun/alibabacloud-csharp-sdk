// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGeoInfoResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGeoInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafGeoInfoResponseBodyContent : TeaModel {
            [NameInMap("Continents")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafGeoInfoResponseBodyContentContinents> Continents { get; set; }
            public class DescribeDcdnWafGeoInfoResponseBodyContentContinents : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions> Regions { get; set; }
                public class DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
