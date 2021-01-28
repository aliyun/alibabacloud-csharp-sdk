// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOfflineLogDeliveryRegionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Areas")]
        [Validation(Required=false)]
        public List<DescribeDcdnOfflineLogDeliveryRegionsResponseBodyAreas> Areas { get; set; }
        public class DescribeDcdnOfflineLogDeliveryRegionsResponseBodyAreas : TeaModel {
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            [NameInMap("AreaId")]
            [Validation(Required=false)]
            public string AreaId { get; set; }

            [NameInMap("RegionInfos")]
            [Validation(Required=false)]
            public List<DescribeDcdnOfflineLogDeliveryRegionsResponseBodyAreasRegionInfos> RegionInfos { get; set; }
            public class DescribeDcdnOfflineLogDeliveryRegionsResponseBodyAreasRegionInfos : TeaModel {
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("IsOverseas")]
                [Validation(Required=false)]
                public string IsOverseas { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

    }

}
