// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodRealtimeDeliveryAccResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about real-time log deliveries.</para>
        /// </summary>
        [NameInMap("RealTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeVodRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData RealTimeDeliveryAccData { get; set; }
        public class DescribeVodRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeVodRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeVodRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData : TeaModel {
                /// <summary>
                /// <para>The number of failed real-time log deliveries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <para>The number of successful real-time log deliveries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessNum")]
                [Validation(Required=false)]
                public int? SuccessNum { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8AA0364-0FDB-4AD5-****-D69FAB8924ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
