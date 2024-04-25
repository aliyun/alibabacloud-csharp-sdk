// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeVodDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                [NameInMap("ReqHitRate")]
                [Validation(Required=false)]
                public float? ReqHitRate { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
