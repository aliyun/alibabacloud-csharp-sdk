// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of Success indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The call data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public HotlineSessionQueryResponseBodyData Data { get; set; }
        public class HotlineSessionQueryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The call detail records.</para>
            /// </summary>
            [NameInMap("CallDetailRecord")]
            [Validation(Required=false)]
            public List<HotlineSessionQueryResponseBodyDataCallDetailRecord> CallDetailRecord { get; set; }
            public class HotlineSessionQueryResponseBodyDataCallDetailRecord : TeaModel {
                /// <summary>
                /// <para>The session ID. The acid in the websocket after an inbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7719786</para>
                /// </summary>
                [NameInMap("Acid")]
                [Validation(Required=false)]
                public string Acid { get; set; }

                /// <summary>
                /// <para>The agent ID.</para>
                /// <remarks>
                /// <para>This value is Null in non-transfer scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ActiveTransferId")]
                [Validation(Required=false)]
                public string ActiveTransferId { get; set; }

                /// <summary>
                /// <para>The call duration. Unit: seconds.</para>
                /// <remarks>
                /// <para>No call duration is available for unanswered calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>37</para>
                /// </summary>
                [NameInMap("CallContinueTime")]
                [Validation(Required=false)]
                public int? CallContinueTime { get; set; }

                /// <summary>
                /// <para>The call result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>normal</b>: The call ended normally.</description></item>
                /// <item><description><b>touchRouteError</b>: The call was terminated in the queue.</description></item>
                /// <item><description><b>touchInQueue</b>: The call was terminated in the queue.</description></item>
                /// <item><description><b>touchInLoss</b>: The call was terminated in the queue.</description></item>
                /// <item><description><b>userHangup</b>: The user hung up or the call was terminated in the IVR.</description></item>
                /// <item><description><b>sysHangup</b>: The system hung up or the call was terminated in the IVR.</description></item>
                /// <item><description><b>transferAgent</b>: The user hung up or the call was terminated in the IVR.</description></item>
                /// <item><description><b>dailing</b>: The agent hung up or the call was terminated during ringing.</description></item>
                /// <item><description><b>TouchRingCallLoss</b>: The call was terminated in the queue or during ringing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("CallResult")]
                [Validation(Required=false)]
                public string CallResult { get; set; }

                /// <summary>
                /// <para>The call type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: outbound call</description></item>
                /// <item><description><b>2</b>: inbound call</description></item>
                /// <item><description><b>3</b>: transferred call</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public int? CallType { get; set; }

                /// <summary>
                /// <para>The called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>135615*****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <para>The number of the caller. For example, a mobile phone number, an agent number, or a robot number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571773</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <para>The time when the call was created.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For outbound calls, this is the time when the outbound call was initiated.</description></item>
                /// </list>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>For inbound calls, this is the time when the call entered the ACC system.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The satisfaction rating level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>2</b>: level-2 satisfaction</description></item>
                /// <item><description><b>3</b>: level-3 satisfaction</description></item>
                /// <item><description><b>4</b>: level-4 satisfaction</description></item>
                /// <item><description><b>5</b>: level-5 satisfaction</description></item>
                /// </list>
                /// <remarks>
                /// <para>No data is available for outbound calls or unanswered calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationLevel")]
                [Validation(Required=false)]
                public int? EvaluationLevel { get; set; }

                /// <summary>
                /// <para>The satisfaction score. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Very dissatisfied.</description></item>
                /// <item><description><b>2</b>: Dissatisfied.</description></item>
                /// <item><description><b>3</b>: Average.</description></item>
                /// <item><description><b>4</b>: Satisfied.</description></item>
                /// <item><description><b>5</b>: Very satisfied.</description></item>
                /// </list>
                /// <remarks>
                /// <para>No data is available for outbound calls or unanswered calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("EvaluationScore")]
                [Validation(Required=false)]
                public int? EvaluationScore { get; set; }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// <remarks>
                /// <para>When CallType is set to <b>1</b>, no skill group information is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The skill group name.</para>
                /// <remarks>
                /// <para>When CallType is set to <b>1</b>, no skill group information is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>AutomationSkillGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The party that hung up. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: System hung up.</description></item>
                /// <item><description><b>2</b>: Customer hung up.</description></item>
                /// <item><description><b>3</b>: Agent hung up.</description></item>
                /// <item><description><b>null</b>: Unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HangUpRole")]
                [Validation(Required=false)]
                public string HangUpRole { get; set; }

                /// <summary>
                /// <para>The hang-up time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:46</para>
                /// </summary>
                [NameInMap("HangUpTime")]
                [Validation(Required=false)]
                public string HangUpTime { get; set; }

                /// <summary>
                /// <para>The globally unique ID of the call details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acc1c58dab4a4dd280e3813c66</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The time when the call entered the queue for hotline assignment.</para>
                /// <remarks>
                /// <para>No queue entry time is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:55</para>
                /// </summary>
                [NameInMap("InQueueTime")]
                [Validation(Required=false)]
                public string InQueueTime { get; set; }

                /// <summary>
                /// <para>The member ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7856876</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <para>The member name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AnonymousMember</para>
                /// </summary>
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                /// <summary>
                /// <para>The time when the call left the queue for hotline assignment.</para>
                /// <remarks>
                /// <para>No queue exit time is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("OutQueueTime")]
                [Validation(Required=false)]
                public string OutQueueTime { get; set; }

                /// <summary>
                /// <para>The agent ID or transferred phone number.</para>
                /// <remarks>
                /// <para>This value is Null in non-transfer scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PassiveTransferId")]
                [Validation(Required=false)]
                public string PassiveTransferId { get; set; }

                /// <summary>
                /// <para>The type of the party to which the session was transferred. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Agent ID.</description></item>
                /// <item><description><b>2</b>: Transferred phone number.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This value is Null in non-transfer scenarios.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PassiveTransferIdType")]
                [Validation(Required=false)]
                public string PassiveTransferIdType { get; set; }

                /// <summary>
                /// <para>The time when the call was answered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("PickUpTime")]
                [Validation(Required=false)]
                public string PickUpTime { get; set; }

                /// <summary>
                /// <para>The queue wait duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("QueueUpContinueTime")]
                [Validation(Required=false)]
                public int? QueueUpContinueTime { get; set; }

                /// <summary>
                /// <para>The ringing duration. Unit: seconds.</para>
                /// <remarks>
                /// <para>No ringing duration is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RingContinueTime")]
                [Validation(Required=false)]
                public int? RingContinueTime { get; set; }

                /// <summary>
                /// <para>The time when ringing ended.</para>
                /// <remarks>
                /// <para>No ringing end time is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:33:09</para>
                /// </summary>
                [NameInMap("RingEndTime")]
                [Validation(Required=false)]
                public string RingEndTime { get; set; }

                /// <summary>
                /// <para>The time when ringing started.</para>
                /// <remarks>
                /// <para>No ringing start time is available for outbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-02 22:32:59</para>
                /// </summary>
                [NameInMap("RingStartTime")]
                [Validation(Required=false)]
                public string RingStartTime { get; set; }

                /// <summary>
                /// <para>The agent ID.</para>
                /// <remarks>
                /// <para>No agent information is available before an agent is assigned for inbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>555555</para>
                /// </summary>
                [NameInMap("ServicerId")]
                [Validation(Required=false)]
                public string ServicerId { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// <remarks>
                /// <para>No agent information is available before an agent is assigned for inbound calls.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>TestAgent</para>
                /// </summary>
                [NameInMap("ServicerName")]
                [Validation(Required=false)]
                public string ServicerName { get; set; }

                /// <summary>
                /// <para>The long-distance call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1861111****</para>
                /// </summary>
                [NameInMap("TrunkCall")]
                [Validation(Required=false)]
                public string TrunkCall { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
