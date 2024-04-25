// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeByteHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeByteHitRateDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeByteHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ByteHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel> ByteHitRateDataModel { get; set; }
            public class DescribeVodDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel : TeaModel {
                [NameInMap("ByteHitRate")]
                [Validation(Required=false)]
                public float? ByteHitRate { get; set; }

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
