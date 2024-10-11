// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainRealTimeByteHitRateDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeVodDomainRealTimeByteHitRateDataResponseBodyData Data { get; set; }
        public class DescribeVodDomainRealTimeByteHitRateDataResponseBodyData : TeaModel {
            [NameInMap("ByteHitRateDataModel")]
            [Validation(Required=false)]
            public List<DescribeVodDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel> ByteHitRateDataModel { get; set; }
            public class DescribeVodDomainRealTimeByteHitRateDataResponseBodyDataByteHitRateDataModel : TeaModel {
                /// <summary>
                /// <para>The byte hit ratio in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8956940476262277</para>
                /// </summary>
                [NameInMap("ByteHitRate")]
                [Validation(Required=false)]
                public float? ByteHitRate { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-05-15T09:13:00Z</para>
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
        /// <para>70A26B11-3673-479C-AEA8-E03FC5D3496D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
