// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetNamespaceStatisticsDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public GetNamespaceStatisticsDataResponseBodyStatistics Statistics { get; set; }
        public class GetNamespaceStatisticsDataResponseBodyStatistics : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<GetNamespaceStatisticsDataResponseBodyStatisticsSeries> Series { get; set; }
            public class GetNamespaceStatisticsDataResponseBodyStatisticsSeries : TeaModel {
                public List<string> Data { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
