// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public HotlineSessionQueryResponseBodyData Data { get; set; }
        public class HotlineSessionQueryResponseBodyData : TeaModel {
            [NameInMap("CallDetailRecord")]
            [Validation(Required=false)]
            public List<HotlineSessionQueryResponseBodyDataCallDetailRecord> CallDetailRecord { get; set; }
            public class HotlineSessionQueryResponseBodyDataCallDetailRecord : TeaModel {
                public string CallResult { get; set; }
                public string TrunkCall { get; set; }
                public string ServicerName { get; set; }
                public string OutQueueTime { get; set; }
                public int? CallContinueTime { get; set; }
                public string CreateTime { get; set; }
                public string PickUpTime { get; set; }
                public int? RingContinueTime { get; set; }
                public string CalledNumber { get; set; }
                public string ServicerId { get; set; }
                public string HangUpTime { get; set; }
                public int? EvaluationLevel { get; set; }
                public string PassiveTransferId { get; set; }
                public string ActiveTransferId { get; set; }
                public string HangUpRole { get; set; }
                public string PassiveTransferIdType { get; set; }
                public string MemberName { get; set; }
                public int? EvaluationScore { get; set; }
                public string Acid { get; set; }
                public string RingStartTime { get; set; }
                public int? CallType { get; set; }
                public string GroupName { get; set; }
                public long? GroupId { get; set; }
                public string RingEndTime { get; set; }
                public string CallingNumber { get; set; }
                public string InQueueTime { get; set; }
                public string MemberId { get; set; }
                public string Id { get; set; }
                public int? QueueUpContinueTime { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
