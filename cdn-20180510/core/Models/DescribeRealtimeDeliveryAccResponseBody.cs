// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeRealtimeDeliveryAccResponseBody : TeaModel {
        [NameInMap("ReatTimeDeliveryAccData")]
        [Validation(Required=false)]
        public DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData ReatTimeDeliveryAccData { get; set; }
        public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccData : TeaModel {
            [NameInMap("AccData")]
            [Validation(Required=false)]
            public List<DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData> AccData { get; set; }
            public class DescribeRealtimeDeliveryAccResponseBodyReatTimeDeliveryAccDataAccData : TeaModel {
                [NameInMap("FailedNum")]
                [Validation(Required=false)]
                public int? FailedNum { get; set; }

                [NameInMap("SuccessNum")]
                [Validation(Required=false)]
                public int? SuccessNum { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>684306D2-2511-4977-991D-CE97E91FD7C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
