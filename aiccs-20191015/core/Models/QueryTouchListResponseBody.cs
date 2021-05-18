// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListResponseBody : TeaModel {
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public QueryTouchListResponseBodyResultData ResultData { get; set; }
        public class QueryTouchListResponseBodyResultData : TeaModel {
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public int? NextPage { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTouchListResponseBodyResultDataData> Data { get; set; }
            public class QueryTouchListResponseBodyResultDataData : TeaModel {
                public int? Status { get; set; }
                public long? ToId { get; set; }
                public long? ParentTouchId { get; set; }
                public string ServicerName { get; set; }
                public int? ChannelType { get; set; }
                public long? CloseTime { get; set; }
                public long? GmtModified { get; set; }
                public long? ServicerId { get; set; }
                public string SwitchUser { get; set; }
                public long? BuId { get; set; }
                public long? FromId { get; set; }
                public long? UserTouchId { get; set; }
                public string TouchTime { get; set; }
                public string TouchContent { get; set; }
                public string Feedback { get; set; }
                public string TouchId { get; set; }
                public long? QueueId { get; set; }
                public long? DepId { get; set; }
                public int? TouchEndReason { get; set; }
                public string MemberName { get; set; }
                public string CommonQueueName { get; set; }
                public long? FirstTime { get; set; }
                public int? TouchType { get; set; }
                public string ChannelId { get; set; }
                public long? GmtCreate { get; set; }
                public long? MemberId { get; set; }
                public QueryTouchListResponseBodyResultDataDataExtAttrs ExtAttrs { get; set; }
                public class QueryTouchListResponseBodyResultDataDataExtAttrs : TeaModel {
                    [NameInMap("EvaluationScore")]
                    [Validation(Required=false)]
                    public int? EvaluationScore { get; set; }

                    [NameInMap("EvaluationLevel")]
                    [Validation(Required=false)]
                    public int? EvaluationLevel { get; set; }

                    [NameInMap("EvaluationSolution")]
                    [Validation(Required=false)]
                    public int? EvaluationSolution { get; set; }

                    [NameInMap("OnlineSessionSource")]
                    [Validation(Required=false)]
                    public int? OnlineSessionSource { get; set; }

                    [NameInMap("OnlineJoinRespInterval")]
                    [Validation(Required=false)]
                    public int? OnlineJoinRespInterval { get; set; }

                    [NameInMap("EvaluationStatus")]
                    [Validation(Required=false)]
                    public int? EvaluationStatus { get; set; }

                    /// <summary>
                    /// 外呼为主叫号码
                    /// </summary>
                    [NameInMap("OutCallRouteNumber")]
                    [Validation(Required=false)]
                    public string OutCallRouteNumber { get; set; }

                    /// <summary>
                    /// 外呼为被叫号码,入呼为被叫号码
                    /// </summary>
                    [NameInMap("Dnis")]
                    [Validation(Required=false)]
                    public string Dnis { get; set; }

                    /// <summary>
                    /// 入呼为主叫号码
                    /// </summary>
                    [NameInMap("Ani")]
                    [Validation(Required=false)]
                    public string Ani { get; set; }

                }
            }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }
            [NameInMap("PreviousPage")]
            [Validation(Required=false)]
            public int? PreviousPage { get; set; }
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public int? OnePageSize { get; set; }
            [NameInMap("Empty")]
            [Validation(Required=false)]
            public bool? Empty { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
