// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public HotlineSessionQueryResponseBodyData Data { get; set; }
        public class HotlineSessionQueryResponseBodyData : TeaModel {
            [NameInMap("CallDetailRecord")]
            [Validation(Required=false)]
            public List<HotlineSessionQueryResponseBodyDataCallDetailRecord> CallDetailRecord { get; set; }
            public class HotlineSessionQueryResponseBodyDataCallDetailRecord : TeaModel {
                [NameInMap("Acid")]
                [Validation(Required=false)]
                public string Acid { get; set; }

                [NameInMap("ActiveTransferId")]
                [Validation(Required=false)]
                public string ActiveTransferId { get; set; }

                [NameInMap("CallContinueTime")]
                [Validation(Required=false)]
                public int? CallContinueTime { get; set; }

                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EvaluationLevel")]
                [Validation(Required=false)]
                public int? EvaluationLevel { get; set; }

                [NameInMap("EvaluationScore")]
                [Validation(Required=false)]
                public int? EvaluationScore { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("HangUpRole")]
                [Validation(Required=false)]
                public string HangUpRole { get; set; }

                [NameInMap("HangUpTime")]
                [Validation(Required=false)]
                public string HangUpTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("InQueueTime")]
                [Validation(Required=false)]
                public string InQueueTime { get; set; }

                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("OutQueueTime")]
                [Validation(Required=false)]
                public string OutQueueTime { get; set; }

                [NameInMap("PassiveTransferId")]
                [Validation(Required=false)]
                public string PassiveTransferId { get; set; }

                [NameInMap("PassiveTransferIdType")]
                [Validation(Required=false)]
                public string PassiveTransferIdType { get; set; }

                [NameInMap("PickUpTime")]
                [Validation(Required=false)]
                public string PickUpTime { get; set; }

                [NameInMap("QueueUpContinueTime")]
                [Validation(Required=false)]
                public int? QueueUpContinueTime { get; set; }

                [NameInMap("RingContinueTime")]
                [Validation(Required=false)]
                public int? RingContinueTime { get; set; }

                [NameInMap("RingEndTime")]
                [Validation(Required=false)]
                public string RingEndTime { get; set; }

                [NameInMap("RingStartTime")]
                [Validation(Required=false)]
                public string RingStartTime { get; set; }

                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public string ServicerId { get; set; }

                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                [NameInMap("TrunkCall")]
                [Validation(Required=false)]
                public string TrunkCall { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
