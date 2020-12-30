// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetTrafficByRegionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrafficDataList")]
        [Validation(Required=false)]
        public GetTrafficByRegionResponseBodyTrafficDataList TrafficDataList { get; set; }
        public class GetTrafficByRegionResponseBodyTrafficDataList : TeaModel {
            [NameInMap("TrafficData")]
            [Validation(Required=false)]
            public List<GetTrafficByRegionResponseBodyTrafficDataListTrafficData> TrafficData { get; set; }
            public class GetTrafficByRegionResponseBodyTrafficDataListTrafficData : TeaModel {
                public long? Traffic { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
