// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetTrafficByRegionResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("TrafficDataList")]
        [Validation(Required=true)]
        public GetTrafficByRegionResponseTrafficDataList TrafficDataList { get; set; }
        public class GetTrafficByRegionResponseTrafficDataList : TeaModel {
            [NameInMap("TrafficData")]
            [Validation(Required=true)]
            public List<GetTrafficByRegionResponseTrafficDataListTrafficData> TrafficData { get; set; }
            public class GetTrafficByRegionResponseTrafficDataListTrafficData : TeaModel {
                public string Name { get; set; }
                public long Traffic { get; set; }
            }
        };

    }

}
