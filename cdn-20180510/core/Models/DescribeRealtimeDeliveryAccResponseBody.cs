// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRealtimeDeliveryAccResponseBody : TeaModel {
        /// <summary>
        /// The statistics about real-time log deliveries.
        /// </summary>
        [NameInMap("ReatTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData ReatTimeDeliveryAccData { get; set; }
        public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData : TeaModel {
                /// <summary>
                /// The number of failed attempts to deliver log data to Log Service.
                /// </summary>
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                /// <summary>
                /// The number of successful deliveries of log data to Log Service.
                /// </summary>
                [NameInMap("SuccessNum")]
                [Validation(Required=false)]
                public int? SuccessNum { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
