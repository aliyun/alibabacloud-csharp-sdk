// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRecommendInstanceTypeResponseBodyData Data { get; set; }
        public class DescribeRecommendInstanceTypeResponseBodyData : TeaModel {
            [NameInMap("RecommendInstanceType")]
            [Validation(Required=false)]
            public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType> RecommendInstanceType { get; set; }
            public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType : TeaModel {
                [NameInMap("zone")]
                [Validation(Required=false)]
                public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZone> Zone { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZone : TeaModel {
                    [NameInMap("ZoneNo")]
                    [Validation(Required=false)]
                    public string ZoneNo { get; set; }

                    [NameInMap("NetworkTypes")]
                    [Validation(Required=false)]
                    public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZoneNetworkTypes NetworkTypes { get; set; }
                    public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZoneNetworkTypes : TeaModel {
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public List<string> NetworkType { get; set; }
                    };

                }

            }
        };

    }

}
