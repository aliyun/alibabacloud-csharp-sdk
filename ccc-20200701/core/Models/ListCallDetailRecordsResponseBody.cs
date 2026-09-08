// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of call records.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsResponseBodyDataList> List { get; set; }
            public class ListCallDetailRecordsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>An additional broker number, which may be used in double-call scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("AdditionalBroker")]
                [Validation(Required=false)]
                public string AdditionalBroker { get; set; }

                /// <summary>
                /// <para>A list of agent IDs, with multiple values separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                /// <summary>
                /// <para>List of agent names involved in the call, separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>坐席小王</para>
                /// </summary>
                [NameInMap("AgentNames")]
                [Validation(Required=false)]
                public string AgentNames { get; set; }

                /// <summary>
                /// <para>The intermediary number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0533127****</para>
                /// </summary>
                [NameInMap("Broker")]
                [Validation(Required=false)]
                public string Broker { get; set; }

                /// <summary>
                /// <para>Call duration. For inbound calls, timing starts when the call enters IVR. For outbound calls, timing starts when the call is connected. The unit is seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

                /// <summary>
                /// <para>The Call-Id field in the underlying SIP protocol. If you need to obtain the call ID from the number provider side, you can retrieve it from this field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
                /// </summary>
                [NameInMap("CallIds")]
                [Validation(Required=false)]
                public string CallIds { get; set; }

                /// <summary>
                /// <para>Called number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("CalledNumber")]
                [Validation(Required=false)]
                public string CalledNumber { get; set; }

                /// <summary>
                /// <para>The callee\&quot;s location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>山东省-济南</para>
                /// </summary>
                [NameInMap("CalleeLocation")]
                [Validation(Required=false)]
                public string CalleeLocation { get; set; }

                /// <summary>
                /// <para>Caller location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京市-北京</para>
                /// </summary>
                [NameInMap("CallerLocation")]
                [Validation(Required=false)]
                public string CallerLocation { get; set; }

                /// <summary>
                /// <para>Calling number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("CallingNumber")]
                [Validation(Required=false)]
                public string CallingNumber { get; set; }

                /// <summary>
                /// <para>Reason for call termination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ContactDisposition")]
                [Validation(Required=false)]
                public string ContactDisposition { get; set; }

                /// <summary>
                /// <para>Call ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job-12515239414412****</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <para>Call type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Outbound</para>
                /// </summary>
                [NameInMap("ContactType")]
                [Validation(Required=false)]
                public string ContactType { get; set; }

                /// <summary>
                /// <para>Dial-up duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                /// <summary>
                /// <para>Reason for failure to connect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NotConnected</para>
                /// </summary>
                [NameInMap("EarlyMediaState")]
                [Validation(Required=false)]
                public string EarlyMediaState { get; set; }

                /// <summary>
                /// <para>The time when the call was established. If the call was not established, this value is empty. The format is a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("EstablishedTime")]
                [Validation(Required=false)]
                public long? EstablishedTime { get; set; }

                /// <summary>
                /// <para>The hold duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("HeldTime")]
                [Validation(Required=false)]
                public long? HeldTime { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>IVR duration, in seconds. This is the time interval from when the IVR starts until the call enters the agent queue (or the customer hangs up).</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("IvrTime")]
                [Validation(Required=false)]
                public long? IvrTime { get; set; }

                /// <summary>
                /// <para>The queue duration, in seconds, measured from when the customer entered the agent queue until the agent started ringing (or the customer abandoned the call, the queue timed out, or the queue overflowed).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <para>Recording duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

                /// <summary>
                /// <para>Indicates whether the recording has been generated. Returns false if the call was not established.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RecordingReady")]
                [Validation(Required=false)]
                public bool? RecordingReady { get; set; }

                /// <summary>
                /// <para>The party that ended the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ReleaseInitiator")]
                [Validation(Required=false)]
                public string ReleaseInitiator { get; set; }

                /// <summary>
                /// <para>Hang-up reason for the channel, indicating why the current channel was disconnected. The value is derived from response codes defined in the SIP protocol. Customers should refer to the SIP protocol to analyze the hang-up reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>486:USER_BUSY</para>
                /// </summary>
                [NameInMap("ReleaseReason")]
                [Validation(Required=false)]
                public string ReleaseReason { get; set; }

                /// <summary>
                /// <para>The call end time, formatted as a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1532707199000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <para>Ring duration, which is the time from when the agent\&quot;s phone starts ringing until the agent answers (or the customer hangs up), in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// <para>The satisfaction description, corresponding to the configuration of the satisfaction module in the satisfaction IVR. This is defined by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>满意</para>
                /// </summary>
                [NameInMap("SatisfactionDescription")]
                [Validation(Required=false)]
                public string SatisfactionDescription { get; set; }

                /// <summary>
                /// <para>Satisfaction rating, represented as a single-digit numeric value entered by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public int? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>The channel used for the satisfaction survey.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IVR</para>
                /// </summary>
                [NameInMap("SatisfactionSurveyChannel")]
                [Validation(Required=false)]
                public string SatisfactionSurveyChannel { get; set; }

                /// <summary>
                /// <para>Indicates whether a satisfaction survey was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SatisfactionSurveyOffered")]
                [Validation(Required=false)]
                public bool? SatisfactionSurveyOffered { get; set; }

                /// <summary>
                /// <para>The IDs of the skill groups to which the agents participating in the call belong. Multiple skill group IDs are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                /// <summary>
                /// <para>The names of the skill groups to which the agents participating in the call belong. Multiple skill group names are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试技能组</para>
                /// </summary>
                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

                /// <summary>
                /// <para>Call start time. For inbound calls, timing starts when the call enters IVR. For outbound calls, timing starts from dial-up. The format is a Unix string in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>Talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                /// <summary>
                /// <para>The customer\&quot;s waiting duration, which equals QueueTime plus RingTime. If the customer abandons the call during waiting, the value is 0. The unit is seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public long? WaitTime { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count. A real numeric value is returned only when PageNumber is 1; otherwise, 0 is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
