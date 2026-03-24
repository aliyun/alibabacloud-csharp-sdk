// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeByteHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainRealTimeByteHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDomainRealTimeByteHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ByteHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel> ByteHitRateDataModel { get; set; }
            public class DescribeDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel : TeaModel {
                [NameInMap("ByteHitRate")]
                [Validation(Required=false)]
                public float? ByteHitRate { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70A26B11-3673-479C-AEA8-E03FC5D3496D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
