// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryTouchListResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>865658FD-80DE-5D49-ABEB-F3CC9863F4F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Data result.</para>
        /// </summary>
        [NameInMap("ResultData")]
        [Validation(Required=false)]
        public QueryTouchListResponseBodyResultData ResultData { get; set; }
        public class QueryTouchListResponseBodyResultData : TeaModel {
            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>Data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTouchListResponseBodyResultDataData> Data { get; set; }
            public class QueryTouchListResponseBodyResultDataData : TeaModel {
                /// <summary>
                /// <para>Tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>905</para>
                /// </summary>
                [NameInMap("BuId")]
                [Validation(Required=false)]
                public long? BuId { get; set; }

                /// <summary>
                /// <para>Session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4f8807a9de024507a3090b5b66a8****</para>
                /// </summary>
                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                /// <summary>
                /// <para>Contact channel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public int? ChannelType { get; set; }

                /// <summary>
                /// <para>Session end time. UNIX timestamp format (unit: milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611207976000</para>
                /// </summary>
                [NameInMap("CloseTime")]
                [Validation(Required=false)]
                public long? CloseTime { get; set; }

                /// <summary>
                /// <para>Skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试1</para>
                /// </summary>
                [NameInMap("CommonQueueName")]
                [Validation(Required=false)]
                public string CommonQueueName { get; set; }

                /// <summary>
                /// <para>Department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DepId")]
                [Validation(Required=false)]
                public long? DepId { get; set; }

                /// <summary>
                /// <para>Extension fields.</para>
                /// </summary>
                [NameInMap("ExtAttrs")]
                [Validation(Required=false)]
                public QueryTouchListResponseBodyResultDataDataExtAttrs ExtAttrs { get; set; }
                public class QueryTouchListResponseBodyResultDataDataExtAttrs : TeaModel {
                    /// <summary>
                    /// <para>Inbound call caller number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>187****0000</para>
                    /// </summary>
                    [NameInMap("Ani")]
                    [Validation(Required=false)]
                    public string Ani { get; set; }

                    /// <summary>
                    /// <para>For outbound calls, this is the called number. For inbound calls, this is also the called number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("Dnis")]
                    [Validation(Required=false)]
                    public string Dnis { get; set; }

                    /// <summary>
                    /// <para>Satisfaction Level. Valid values:  </para>
                    /// <list type="bullet">
                    /// <item><description><b>2</b>: Level 2 satisfaction.  </description></item>
                    /// <item><description><b>3</b>: Level 3 satisfaction.  </description></item>
                    /// <item><description><b>4</b>: Level 4 satisfaction.  </description></item>
                    /// <item><description><b>5</b>: Level 5 satisfaction.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("EvaluationLevel")]
                    [Validation(Required=false)]
                    public int? EvaluationLevel { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rating. Valid values:</para>
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
                    /// <para>Evaluation solution.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("EvaluationSolution")]
                    [Validation(Required=false)]
                    public int? EvaluationSolution { get; set; }

                    /// <summary>
                    /// <para>Evaluation status. Valid values:</para>
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
                    /// <para>Duration until first response (unit: seconds).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OnlineJoinRespInterval")]
                    [Validation(Required=false)]
                    public int? OnlineJoinRespInterval { get; set; }

                    /// <summary>
                    /// <para>Online session source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OnlineSessionSource")]
                    [Validation(Required=false)]
                    public int? OnlineSessionSource { get; set; }

                    /// <summary>
                    /// <para>Outbound call caller number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05712688****</para>
                    /// </summary>
                    [NameInMap("OutCallRouteNumber")]
                    [Validation(Required=false)]
                    public string OutCallRouteNumber { get; set; }

                }

                /// <summary>
                /// <para>Large object.</para>
                /// </summary>
                [NameInMap("ExtAttrsString")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtAttrsString { get; set; }

                /// <summary>
                /// <para>Feedback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxxx</para>
                /// </summary>
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public string Feedback { get; set; }

                /// <summary>
                /// <para>Conversation pickup time, in UNIX timestamp format (unit: milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// <para>Conversation initiator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("FromId")]
                [Validation(Required=false)]
                public long? FromId { get; set; }

                /// <summary>
                /// <para>Creation Time, in UNIX timestamp format (unit: milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611209971000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Update Time. UNIX timestamp format (unit: milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1611207979000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>Membership ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6400665****</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public long? MemberId { get; set; }

                /// <summary>
                /// <para>Membership name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>访客</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>Parent contact ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ParentTouchId")]
                [Validation(Required=false)]
                public long? ParentTouchId { get; set; }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                /// <summary>
                /// <para>Service agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>67****</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public long? ServicerId { get; set; }

                /// <summary>
                /// <para>Service agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>Contact status. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Incoming call received.  </description></item>
                /// <item><description><b>2</b>: Agent has joined.  </description></item>
                /// <item><description><b>3</b>: In conversation.  </description></item>
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
                /// <para>Change owner list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SwitchUser")]
                [Validation(Required=false)]
                public string SwitchUser { get; set; }

                /// <summary>
                /// <para>Conversation recipient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>67****</para>
                /// </summary>
                [NameInMap("ToId")]
                [Validation(Required=false)]
                public long? ToId { get; set; }

                /// <summary>
                /// <para>The reason why the session ended. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Unknown.  </description></item>
                /// <item><description><b>1</b>: Contact failed.  </description></item>
                /// <item><description><b>2</b>: Terminated by customer.  </description></item>
                /// <item><description><b>3</b>: Terminated by agent.  </description></item>
                /// <item><description><b>4</b>: Call abnormally interrupted.  </description></item>
                /// <item><description><b>5</b>: Terminated due to change owner.  </description></item>
                /// <item><description><b>6</b>: Terminated by system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TouchContent")]
                [Validation(Required=false)]
                public string TouchContent { get; set; }

                /// <summary>
                /// <para>End reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TouchEndReason")]
                [Validation(Required=false)]
                public int? TouchEndReason { get; set; }

                /// <summary>
                /// <para>Touch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1386****</para>
                /// </summary>
                [NameInMap("TouchId")]
                [Validation(Required=false)]
                public string TouchId { get; set; }

                /// <summary>
                /// <para>Conversation duration (unit: seconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("TouchTime")]
                [Validation(Required=false)]
                public string TouchTime { get; set; }

                /// <summary>
                /// <para>Touch type. Valid values:</para>
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
                /// <para>User touch ID.</para>
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
            /// <para>The page number of the next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NextPage")]
            [Validation(Required=false)]
            public int? NextPage { get; set; }

            /// <summary>
            /// <para>Page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("OnePageSize")]
            [Validation(Required=false)]
            public int? OnePageSize { get; set; }

            /// <summary>
            /// <para>Previous page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PreviousPage")]
            [Validation(Required=false)]
            public int? PreviousPage { get; set; }

            /// <summary>
            /// <para>Total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the API call succeeded. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.  </description></item>
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
