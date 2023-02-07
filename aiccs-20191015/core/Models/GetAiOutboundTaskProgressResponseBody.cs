// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskProgressResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskProgressResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskProgressResponseBodyData : TeaModel {
            [NameInMap("CalloutProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataCalloutProgress CalloutProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataCalloutProgress : TeaModel {
                [NameInMap("CallLossCount")]
                [Validation(Required=false)]
                public int? CallLossCount { get; set; }

                [NameInMap("CallLossRate")]
                [Validation(Required=false)]
                public float? CallLossRate { get; set; }

                [NameInMap("CallOutConnectCount")]
                [Validation(Required=false)]
                public int? CallOutConnectCount { get; set; }

                [NameInMap("CallOutConnectRate")]
                [Validation(Required=false)]
                public float? CallOutConnectRate { get; set; }

                [NameInMap("CallOutCount")]
                [Validation(Required=false)]
                public int? CallOutCount { get; set; }

                [NameInMap("CallOutServicerPickupCount")]
                [Validation(Required=false)]
                public int? CallOutServicerPickupCount { get; set; }

                [NameInMap("CallOutServicerPickupRate")]
                [Validation(Required=false)]
                public float? CallOutServicerPickupRate { get; set; }

                [NameInMap("CallOutUserPickupCount")]
                [Validation(Required=false)]
                public int? CallOutUserPickupCount { get; set; }

                [NameInMap("CallOutUserPickupRate")]
                [Validation(Required=false)]
                public float? CallOutUserPickupRate { get; set; }

            }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("TaskProgress")]
            [Validation(Required=false)]
            public GetAiOutboundTaskProgressResponseBodyDataTaskProgress TaskProgress { get; set; }
            public class GetAiOutboundTaskProgressResponseBodyDataTaskProgress : TeaModel {
                [NameInMap("CallingCount")]
                [Validation(Required=false)]
                public int? CallingCount { get; set; }

                [NameInMap("ConnectCount")]
                [Validation(Required=false)]
                public int? ConnectCount { get; set; }

                [NameInMap("ConnectRate")]
                [Validation(Required=false)]
                public float? ConnectRate { get; set; }

                [NameInMap("FinishCount")]
                [Validation(Required=false)]
                public int? FinishCount { get; set; }

                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public float? FinishRate { get; set; }

                [NameInMap("ServicerPickupCount")]
                [Validation(Required=false)]
                public int? ServicerPickupCount { get; set; }

                [NameInMap("ServicerPickupRate")]
                [Validation(Required=false)]
                public float? ServicerPickupRate { get; set; }

                [NameInMap("TerminateCount")]
                [Validation(Required=false)]
                public int? TerminateCount { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("UserPickupCount")]
                [Validation(Required=false)]
                public int? UserPickupCount { get; set; }

                [NameInMap("UserPickupRate")]
                [Validation(Required=false)]
                public float? UserPickupRate { get; set; }

                [NameInMap("WaitingCallCount")]
                [Validation(Required=false)]
                public int? WaitingCallCount { get; set; }

                [NameInMap("WaitingRecallCount")]
                [Validation(Required=false)]
                public int? WaitingRecallCount { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

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
