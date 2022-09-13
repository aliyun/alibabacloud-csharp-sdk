// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBlockedRegionsResponseBody : TeaModel {
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public DescribeDcdnBlockedRegionsResponseBodyInfoList InfoList { get; set; }
        public class DescribeDcdnBlockedRegionsResponseBodyInfoList : TeaModel {
            [NameInMap("InfoItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem> InfoItem { get; set; }
            public class DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem : TeaModel {
                [NameInMap("Continent")]
                [Validation(Required=false)]
                public string Continent { get; set; }

                [NameInMap("CountriesAndRegions")]
                [Validation(Required=false)]
                public string CountriesAndRegions { get; set; }

                [NameInMap("CountriesAndRegionsName")]
                [Validation(Required=false)]
                public string CountriesAndRegionsName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
