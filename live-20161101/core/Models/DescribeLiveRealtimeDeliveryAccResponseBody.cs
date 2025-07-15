// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRealtimeDeliveryAccResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about real-time log deliveries.</para>
        /// </summary>
        [NameInMap("RealTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData RealTimeDeliveryAccData { get; set; }
        public class DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeLiveRealtimeDeliveryAccResponseBodyRealTimeDeliveryAccDataAccData : TeaModel {
                /// <summary>
                /// <para>The number of failed real-time log deliveries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// <para>The number of successful real-time log deliveries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>321321</para>
                /// </summary>
                [NameInMap("SuccessNum")]
                [Validation(Required=false)]
                public int? SuccessNum { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T20:00:00Z</para>
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
        /// <para>684306D2-2511-4977-991D-CE97E91FD7C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
