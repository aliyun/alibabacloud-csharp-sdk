// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>865658FD-80DE-5D49-ABEB-F3CC9863F4F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public QueryTouchListResponseBodyResultData ResultData { get; set; }
        public class QueryTouchListResponseBodyResultData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTouchListResponseBodyResultDataData> Data { get; set; }
            public class QueryTouchListResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>905</para>
                /// </summary>
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4f8807a9de024507a3090b5b66a8****</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1611207976000</para>
                /// </summary>
                [NameInMap("CloseTime")]
                [Validation(Required=false)]
                public long? CloseTime { get; set; }

                [NameInMap("CommonQueueName")]
                [Validation(Required=false)]
                public string CommonQueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DepId")]
                [Validation(Required=false)]
                public long? DepId { get; set; }

                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public QueryTouchListResponseBodyResultDataDataExtAttrs ExtAttrs { get; set; }
                public class QueryTouchListResponseBodyResultDataDataExtAttrs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>187****0000</para>
                    /// </summary>
                    [NameInMap("Ani")]
                    [Validation(Required=false)]
                    public string Ani { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("Dnis")]
                    [Validation(Required=false)]
                    public string Dnis { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("EvaluationLevel")]
                    [Validation(Required=false)]
                    public int? EvaluationLevel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EvaluationScore")]
                    [Validation(Required=false)]
                    public int? EvaluationScore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("EvaluationSolution")]
                    [Validation(Required=false)]
                    public int? EvaluationSolution { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EvaluationStatus")]
                    [Validation(Required=false)]
                    public int? EvaluationStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OnlineJoinRespInterval")]
                    [Validation(Required=false)]
                    public int? OnlineJoinRespInterval { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OnlineSessionSource")]
                    [Validation(Required=false)]
                    public int? OnlineSessionSource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("OutCallRouteNumber")]
                    [Validation(Required=false)]
                    public string OutCallRouteNumber { get; set; }

                }

                [NameInMap("ExtAttrsString")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtAttrsString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("FromId")]
                [Validation(Required=false)]
                public long? FromId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1611207979000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentTouchId")]
                [Validation(Required=false)]
                public long? ParentTouchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>67****</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13900001234</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SwitchUser")]
                [Validation(Required=false)]
                public string SwitchUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>678026</para>
                /// </summary>
                [NameInMap("ToId")]
                [Validation(Required=false)]
                public long? ToId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TouchContent")]
                [Validation(Required=false)]
                public string TouchContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TouchEndReason")]
                [Validation(Required=false)]
                public int? TouchEndReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1386****</para>
                /// </summary>
                [NameInMap("TouchId")]
                [Validation(Required=false)]
                public string TouchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("TouchTime")]
                [Validation(Required=false)]
                public string TouchTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TouchType")]
                [Validation(Required=false)]
                public int? TouchType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1386****</para>
                /// </summary>
                [NameInMap("UserTouchId")]
                [Validation(Required=false)]
                public long? UserTouchId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Empty")]
            [Validation(Required=false)]
            public bool? Empty { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public int? NextPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public int? OnePageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PreviousPage")]
            [Validation(Required=false)]
            public int? PreviousPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
