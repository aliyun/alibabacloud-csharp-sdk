// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeUserBuyStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUserBuyStatusResponseBodyData Data { get; set; }
        public class DescribeUserBuyStatusResponseBodyData : TeaModel {
            [NameInMap("CanBuy")]
            [Validation(Required=false)]
            public bool? CanBuy { get; set; }

            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            [NameInMap("DurationDays")]
            [Validation(Required=false)]
            public long? DurationDays { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            [NameInMap("MainUserName")]
            [Validation(Required=false)]
            public string MainUserName { get; set; }

            [NameInMap("MasterUserId")]
            [Validation(Required=false)]
            public long? MasterUserId { get; set; }

            [NameInMap("MasterUserName")]
            [Validation(Required=false)]
            public string MasterUserName { get; set; }

            [NameInMap("SasInstanceId")]
            [Validation(Required=false)]
            public string SasInstanceId { get; set; }

            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
