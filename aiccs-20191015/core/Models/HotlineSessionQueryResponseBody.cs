// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A value of &quot;Success&quot; indicates that the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Call data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public HotlineSessionQueryResponseBodyData Data { get; set; }
        public class HotlineSessionQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Call detail records.</para>
            /// </summary>
            [NameInMap("CallDetailRecord")]
            [Validation(Required=false)]
            public List<HotlineSessionQueryResponseBodyDataCallDetailRecord> CallDetailRecord { get; set; }
            public class HotlineSessionQueryResponseBodyDataCallDetailRecord : TeaModel {
                /// <summary>
                /// <para>Session ID. The acid in WebSocket after an incoming call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7719786</para>
                /// </summary>
                [NameInMap("Acid")]
                [Validation(Required=false)]
                public string Acid { get; set; }

                /// <summary>
                /// <para>Agent ID.  </para>
                /// <remarks>
                /// <para>This field is null in non–change owner scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ActiveTransferId")]
                [Validation(Required=false)]
                public string ActiveTransferId { get; set; }

                /// <summary>
                /// <para>Call duration, in seconds.  </para>
                /// <remarks>
                /// <para>Unconnected calls do not include call duration.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>37</para>
                /// </summary>
                [NameInMap("CallContinueTime")]
                [Validation(Required=false)]
                public int? CallContinueTime { get; set; }

                /// <summary>
                /// <para>Call result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: Normal hang-up.</description></item>
                /// <item><description><b>touchRouteError</b>: Queue hang-up.</description></item>
                /// <item><description><b>touchInQueue</b>: Queue hang-up.</description></item>
                /// <item><description><b>touchInLoss</b>: Queue hang-up.</description></item>
                /// <item><description><b>userHangup</b>: User hang-up or IVR hang-up.</description></item>
                /// <item><description><b>sysHangup</b>: System hang-up or IVR hang-up.</description></item>
                /// <item><description><b>transferAgent</b>: User hang-up or IVR hang-up.</description></item>
                /// <item><description><b>dailing</b>: Agent hang-up or ring-off hang-up.</description></item>
                /// <item><description><b>TouchRingCallLoss</b>: Queue hang-up or ring-off hang-up.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                /// <summary>
                /// <para>Call type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Outbound call</description></item>
                /// <item><description><b>2</b>: Inbound call</description></item>
                /// <item><description><b>3</b>: Change owner</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <para>Called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>135615*****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <para>Calling party number, such as a user\&quot;s phone number, agent number, or machine number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571773</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <para>Call creation time.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>In outbound scenarios, this is the time when the outbound call was initiated.</description></item>
                /// <item><description>In inbound scenarios, this is the time when the call entered the ACC system.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Satisfaction rating, indicated by star level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: Two-star satisfaction</description></item>
                /// <item><description><b>3</b>: Three-star satisfaction</description></item>
                /// <item><description><b>4</b>: Four-star satisfaction</description></item>
                /// <item><description><b>5</b>: Five-star satisfaction</description></item>
                /// </list>
                /// <remarks>
                /// <para>This field has no data in outbound scenarios or scenarios where the call was not answered.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationLevel")]
                [Validation(Required=false)]
                public int? EvaluationLevel { get; set; }

                /// <summary>
                /// <para>Satisfaction score. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Very dissatisfied</description></item>
                /// <item><description><b>2</b>: Dissatisfied</description></item>
                /// <item><description><b>3</b>: Neutral</description></item>
                /// <item><description><b>4</b>: Satisfied</description></item>
                /// <item><description><b>5</b>: Very satisfied</description></item>
                /// </list>
                /// <remarks>
                /// <para>This field has no data in outbound scenarios or scenarios where the call was not answered.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationScore")]
                [Validation(Required=false)]
                public int? EvaluationScore { get; set; }

                /// <summary>
                /// <para>Skill group ID.  </para>
                /// <remarks>
                /// <para>When CallType is <b>1</b>, outbound call scenarios do not include skill group information.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>Skill group name.  </para>
                /// <remarks>
                /// <para>When CallType is <b>1</b>, outbound call scenarios do not include skill group information.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>自动化技能组</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>Party that hung up. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: System hung up  </description></item>
                /// <item><description><b>2</b>: Customer hung up  </description></item>
                /// <item><description><b>3</b>: Agent hung up  </description></item>
                /// <item><description><b>null</b>: Unknown</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HangUpRole")]
                [Validation(Required=false)]
                public string HangUpRole { get; set; }

                /// <summary>
                /// <para>Hang-up time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:46</para>
                /// </summary>
                [NameInMap("HangUpTime")]
                [Validation(Required=false)]
                public string HangUpTime { get; set; }

                /// <summary>
                /// <para>The GUID of the call detail record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc1c58dab4a4dd280e3813c66</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Time when the call entered the queue for assignment.  </para>
                /// <remarks>
                /// <para>Outbound call scenarios do not include queue entry time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("InQueueTime")]
                [Validation(Required=false)]
                public string InQueueTime { get; set; }

                /// <summary>
                /// <para>Membership ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7856876</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <para>Membership name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>匿名会员</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The time when the hotline call is assigned and dequeued.</para>
                /// <remarks>
                /// <para>Outbound scenarios do not have a dequeue time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("OutQueueTime")]
                [Validation(Required=false)]
                public string OutQueueTime { get; set; }

                /// <summary>
                /// <para>Agent ID. The phone number to which the call is transferred.</para>
                /// <remarks>
                /// <para>This field is null in non-transfer scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PassiveTransferId")]
                [Validation(Required=false)]
                public string PassiveTransferId { get; set; }

                /// <summary>
                /// <para>The recipient of the transferred session. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Agent ID.</description></item>
                /// <item><description><b>2</b>: Transferred phone number.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This field is null in non-transfer scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassiveTransferIdType")]
                [Validation(Required=false)]
                public string PassiveTransferIdType { get; set; }

                /// <summary>
                /// <para>The time when the call is answered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("PickUpTime")]
                [Validation(Required=false)]
                public string PickUpTime { get; set; }

                /// <summary>
                /// <para>Queue duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("QueueUpContinueTime")]
                [Validation(Required=false)]
                public int? QueueUpContinueTime { get; set; }

                /// <summary>
                /// <para>Ringing duration, in seconds.</para>
                /// <remarks>
                /// <para>Outbound scenarios do not have ringing duration.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RingContinueTime")]
                [Validation(Required=false)]
                public int? RingContinueTime { get; set; }

                /// <summary>
                /// <para>The time when ringing ends.</para>
                /// <remarks>
                /// <para>Outbound scenarios do not have a ring end time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("RingEndTime")]
                [Validation(Required=false)]
                public string RingEndTime { get; set; }

                /// <summary>
                /// <para>Ringing start time.  </para>
                /// <remarks>
                /// <para>Outbound call scenarios do not include ringing start time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("RingStartTime")]
                [Validation(Required=false)]
                public string RingStartTime { get; set; }

                /// <summary>
                /// <para>Agent ID.  </para>
                /// <remarks>
                /// <para>In inbound scenarios, agent information is unavailable until the call is assigned to an agent.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>555555</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public string ServicerId { get; set; }

                /// <summary>
                /// <para>Agent name.</para>
                /// <remarks>
                /// <para>Agent information is unavailable before the call is assigned to an agent in inbound scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>刘测试</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>Long-distance call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1861111****</para>
                /// </summary>
                [NameInMap("TrunkCall")]
                [Validation(Required=false)]
                public string TrunkCall { get; set; }

            }

            /// <summary>
            /// <para>Current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Number of items per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
