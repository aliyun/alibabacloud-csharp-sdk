// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>865658FD-80DE-5D49-ABEB-F3CC9863F4F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The data result.</para>
        /// </summary>
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public QueryTouchListResponseBodyResultData ResultData { get; set; }
        public class QueryTouchListResponseBodyResultData : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTouchListResponseBodyResultDataData> Data { get; set; }
            public class QueryTouchListResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>905</para>
                /// </summary>
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f8807a9de024507a3090b5b66a8****</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>The touch channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                /// <summary>
                /// <para>The session end time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611207976000</para>
                /// </summary>
                [NameInMap("CloseTime")]
                [Validation(Required=false)]
                public long? CloseTime { get; set; }

                /// <summary>
                /// <para>The skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test1</para>
                /// </summary>
                [NameInMap("CommonQueueName")]
                [Validation(Required=false)]
                public string CommonQueueName { get; set; }

                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DepId")]
                [Validation(Required=false)]
                public long? DepId { get; set; }

                /// <summary>
                /// <para>The extended fields.</para>
                /// </summary>
                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public QueryTouchListResponseBodyResultDataDataExtAttrs ExtAttrs { get; set; }
                public class QueryTouchListResponseBodyResultDataDataExtAttrs : TeaModel {
                    /// <summary>
                    /// <para>The calling number for inbound calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>187****0000</para>
                    /// </summary>
                    [NameInMap("Ani")]
                    [Validation(Required=false)]
                    public string Ani { get; set; }

                    /// <summary>
                    /// <para>The called number for both outbound and inbound calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("Dnis")]
                    [Validation(Required=false)]
                    public string Dnis { get; set; }

                    /// <summary>
                    /// <para>The satisfaction level. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>2</b>: 2-level satisfaction.</description></item>
                    /// <item><description><b>3</b>: 3-level satisfaction.</description></item>
                    /// <item><description><b>4</b>: 4-level satisfaction.</description></item>
                    /// <item><description><b>5</b>: 5-level satisfaction.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("EvaluationLevel")]
                    [Validation(Required=false)]
                    public int? EvaluationLevel { get; set; }

                    /// <summary>
                    /// <para>The satisfaction score. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>1</b>: Very dissatisfied.</description></item>
                    /// <item><description><b>2</b>: Dissatisfied.</description></item>
                    /// <item><description><b>3</b>: Neutral.</description></item>
                    /// <item><description><b>4</b>: Satisfied.</description></item>
                    /// <item><description><b>5</b>: Very satisfied.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EvaluationScore")]
                    [Validation(Required=false)]
                    public int? EvaluationScore { get; set; }

                    /// <summary>
                    /// <para>The evaluation Solutions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("EvaluationSolution")]
                    [Validation(Required=false)]
                    public int? EvaluationSolution { get; set; }

                    /// <summary>
                    /// <para>The evaluation status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>-1</b>: Evaluation not initiated.</description></item>
                    /// <item><description><b>0</b>: Not evaluated.</description></item>
                    /// <item><description><b>1</b>: Evaluated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EvaluationStatus")]
                    [Validation(Required=false)]
                    public int? EvaluationStatus { get; set; }

                    /// <summary>
                    /// <para>The first response duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OnlineJoinRespInterval")]
                    [Validation(Required=false)]
                    public int? OnlineJoinRespInterval { get; set; }

                    /// <summary>
                    /// <para>The online session source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OnlineSessionSource")]
                    [Validation(Required=false)]
                    public int? OnlineSessionSource { get; set; }

                    /// <summary>
                    /// <para>The calling number for outbound calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("OutCallRouteNumber")]
                    [Validation(Required=false)]
                    public string OutCallRouteNumber { get; set; }

                }

                /// <summary>
                /// <para>The large field.</para>
                /// </summary>
                [NameInMap("ExtAttrsString")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtAttrsString { get; set; }

                /// <summary>
                /// <para>The feedback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                /// <summary>
                /// <para>The session pickup time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// <para>The session initiator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("FromId")]
                [Validation(Required=false)]
                public long? FromId { get; set; }

                /// <summary>
                /// <para>The creation time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The update time. The value is a timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611207979000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The member ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                /// <summary>
                /// <para>The member name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Visitor</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The parent touch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentTouchId")]
                [Validation(Required=false)]
                public long? ParentTouchId { get; set; }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>67****</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>The touch status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Queued.</description></item>
                /// <item><description><b>2</b>: Agent connected.</description></item>
                /// <item><description><b>3</b>: In call.</description></item>
                /// <item><description><b>4</b>: Ended.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The transfer list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SwitchUser")]
                [Validation(Required=false)]
                public string SwitchUser { get; set; }

                /// <summary>
                /// <para>The session receiver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>67****</para>
                /// </summary>
                [NameInMap("ToId")]
                [Validation(Required=false)]
                public long? ToId { get; set; }

                /// <summary>
                /// <para>The session end reason. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Unknown.</description></item>
                /// <item><description><b>1</b>: Touch unsuccessful.</description></item>
                /// <item><description><b>2</b>: Customer terminated.</description></item>
                /// <item><description><b>3</b>: Agent terminated.</description></item>
                /// <item><description><b>4</b>: Call abnormally interrupted.</description></item>
                /// <item><description><b>5</b>: Transfer terminated.</description></item>
                /// <item><description><b>6</b>: System terminated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TouchContent")]
                [Validation(Required=false)]
                public string TouchContent { get; set; }

                /// <summary>
                /// <para>The end reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TouchEndReason")]
                [Validation(Required=false)]
                public int? TouchEndReason { get; set; }

                /// <summary>
                /// <para>The contact ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1386****</para>
                /// </summary>
                [NameInMap("TouchId")]
                [Validation(Required=false)]
                public string TouchId { get; set; }

                /// <summary>
                /// <para>The session duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("TouchTime")]
                [Validation(Required=false)]
                public string TouchTime { get; set; }

                /// <summary>
                /// <para>The touch type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Active touch.</description></item>
                /// <item><description><b>2</b>: Passive touch.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TouchType")]
                [Validation(Required=false)]
                public int? TouchType { get; set; }

                /// <summary>
                /// <para>The user touch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1386****</para>
                /// </summary>
                [NameInMap("UserTouchId")]
                [Validation(Required=false)]
                public long? UserTouchId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the result is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Empty")]
            [Validation(Required=false)]
            public bool? Empty { get; set; }

            /// <summary>
            /// <para>The next page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public int? NextPage { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public int? OnePageSize { get; set; }

            /// <summary>
            /// <para>The previous page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PreviousPage")]
            [Validation(Required=false)]
            public int? PreviousPage { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
