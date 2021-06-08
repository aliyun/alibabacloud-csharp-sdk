// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBlockedRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public DescribeDcdnBlockedRegionsResponseBodyInfoList InfoList { get; set; }
        public class DescribeDcdnBlockedRegionsResponseBodyInfoList : TeaModel {
            [NameInMap("InfoItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem> InfoItem { get; set; }
            public class DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem : TeaModel {
                public string CountriesAndRegions { get; set; }
                public string Continent { get; set; }
                public string CountriesAndRegionsName { get; set; }
            }
        };

    }

}
