// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of byte hit ratios.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ReqHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel> ReqHitRateDataModel { get; set; }
            public class DescribeDcdnDomainRealTimeReqHitRateDataResponseBodyDataReqHitRateDataModel : TeaModel {
                /// <summary>
                /// <para>The request hit ratio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8956940476262277</para>
                /// </summary>
                [NameInMap("ReqHitRate")]
                [Validation(Required=false)]
                public float? ReqHitRate { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-10-20T04:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B955107D-E658-4E77-B913-E0AC3D31693E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
