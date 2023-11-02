// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEventDisposeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeEventDisposeResponseBodyData Data { get; set; }
        public class DescribeEventDisposeResponseBodyData : TeaModel {
            [NameInMap("EventDispose")]
            [Validation(Required=false)]
            public List<object> EventDispose { get; set; }

            [NameInMap("ReceiverInfo")]
            [Validation(Required=false)]
            public DescribeEventDisposeResponseBodyDataReceiverInfo ReceiverInfo { get; set; }
            public class DescribeEventDisposeResponseBodyDataReceiverInfo : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public string Channel { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("MessageTitle")]
                [Validation(Required=false)]
                public string MessageTitle { get; set; }

                [NameInMap("Receiver")]
                [Validation(Required=false)]
                public string Receiver { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
