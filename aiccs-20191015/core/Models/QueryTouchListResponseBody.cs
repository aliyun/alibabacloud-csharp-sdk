// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public QueryTouchListResponseBodyResultData ResultData { get; set; }
        public class QueryTouchListResponseBodyResultData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTouchListResponseBodyResultDataData> Data { get; set; }
            public class QueryTouchListResponseBodyResultDataData : TeaModel {
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                [NameInMap("CloseTime")]
                [Validation(Required=false)]
                public long? CloseTime { get; set; }

                [NameInMap("CommonQueueName")]
                [Validation(Required=false)]
                public string CommonQueueName { get; set; }

                [NameInMap("DepId")]
                [Validation(Required=false)]
                public long? DepId { get; set; }

                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public QueryTouchListResponseBodyResultDataDataExtAttrs ExtAttrs { get; set; }
                public class QueryTouchListResponseBodyResultDataDataExtAttrs : TeaModel {
                    [NameInMap("Ani")]
                    [Validation(Required=false)]
                    public string Ani { get; set; }

                    [NameInMap("Dnis")]
                    [Validation(Required=false)]
                    public string Dnis { get; set; }

                    [NameInMap("EvaluationLevel")]
                    [Validation(Required=false)]
                    public int? EvaluationLevel { get; set; }

                    [NameInMap("EvaluationScore")]
                    [Validation(Required=false)]
                    public int? EvaluationScore { get; set; }

                    [NameInMap("EvaluationSolution")]
                    [Validation(Required=false)]
                    public int? EvaluationSolution { get; set; }

                    [NameInMap("EvaluationStatus")]
                    [Validation(Required=false)]
                    public int? EvaluationStatus { get; set; }

                    [NameInMap("OnlineJoinRespInterval")]
                    [Validation(Required=false)]
                    public int? OnlineJoinRespInterval { get; set; }

                    [NameInMap("OnlineSessionSource")]
                    [Validation(Required=false)]
                    public int? OnlineSessionSource { get; set; }

                    [NameInMap("OutCallRouteNumber")]
                    [Validation(Required=false)]
                    public string OutCallRouteNumber { get; set; }

                }

                [NameInMap("ExtAttrsString")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtAttrsString { get; set; }

                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                [NameInMap("FromId")]
                [Validation(Required=false)]
                public long? FromId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("ParentTouchId")]
                [Validation(Required=false)]
                public long? ParentTouchId { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("SwitchUser")]
                [Validation(Required=false)]
                public string SwitchUser { get; set; }

                [NameInMap("ToId")]
                [Validation(Required=false)]
                public long? ToId { get; set; }

                [NameInMap("TouchContent")]
                [Validation(Required=false)]
                public string TouchContent { get; set; }

                [NameInMap("TouchEndReason")]
                [Validation(Required=false)]
                public int? TouchEndReason { get; set; }

                [NameInMap("TouchId")]
                [Validation(Required=false)]
                public string TouchId { get; set; }

                [NameInMap("TouchTime")]
                [Validation(Required=false)]
                public string TouchTime { get; set; }

                [NameInMap("TouchType")]
                [Validation(Required=false)]
                public int? TouchType { get; set; }

                [NameInMap("UserTouchId")]
                [Validation(Required=false)]
                public long? UserTouchId { get; set; }

            }

            [NameInMap("Empty")]
            [Validation(Required=false)]
            public bool? Empty { get; set; }

            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public int? NextPage { get; set; }

            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public int? OnePageSize { get; set; }

            [NameInMap("PreviousPage")]
            [Validation(Required=false)]
            public int? PreviousPage { get; set; }

            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
