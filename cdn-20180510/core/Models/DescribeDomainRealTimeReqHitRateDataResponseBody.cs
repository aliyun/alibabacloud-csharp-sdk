// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                [NameInMap("ReqHitRate")]
                [Validation(Required=false)]
                public float? ReqHitRate { get; set; }

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
