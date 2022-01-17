// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCommoditiesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCommoditiesResponseBodyData Data { get; set; }
        public class DescribeCommoditiesResponseBodyData : TeaModel {
            [NameInMap("Commodities")]
            [Validation(Required=false)]
            public DescribeCommoditiesResponseBodyDataCommodities Commodities { get; set; }
            public class DescribeCommoditiesResponseBodyDataCommodities : TeaModel {
                [NameInMap("Commodity")]
                [Validation(Required=false)]
                public List<DescribeCommoditiesResponseBodyDataCommoditiesCommodity> Commodity { get; set; }
                public class DescribeCommoditiesResponseBodyDataCommoditiesCommodity : TeaModel {
                    [NameInMap("ApplicationId")]
                    [Validation(Required=false)]
                    public string ApplicationId { get; set; }

                    [NameInMap("CommodityId")]
                    [Validation(Required=false)]
                    public string CommodityId { get; set; }

                    [NameInMap("Properties")]
                    [Validation(Required=false)]
                    public string Properties { get; set; }

                }

            }
            [NameInMap("Pageable")]
            [Validation(Required=false)]
            public DescribeCommoditiesResponseBodyDataPageable Pageable { get; set; }
            public class DescribeCommoditiesResponseBodyDataPageable : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
