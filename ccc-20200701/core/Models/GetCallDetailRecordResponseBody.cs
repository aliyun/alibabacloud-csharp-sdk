// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            [NameInMap("AgentEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataAgentEvents> AgentEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataAgentEvents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataAgentEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataAgentEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Dialing</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent1@ccc-test,agent2@ccc-test</para>
            /// </summary>
            [NameInMap("AgentIds")]
            [Validation(Required=false)]
            public string AgentIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent1,agent2</para>
            /// </summary>
            [NameInMap("AgentNames")]
            [Validation(Required=false)]
            public string AgentNames { get; set; }

            [NameInMap("AnalyticsReport")]
            [Validation(Required=false)]
            public GetCallDetailRecordResponseBodyDataAnalyticsReport AnalyticsReport { get; set; }
            public class GetCallDetailRecordResponseBodyDataAnalyticsReport : TeaModel {
                [NameInMap("Emotion")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportEmotion Emotion { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportEmotion : TeaModel {
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public int? Confidence { get; set; }

                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ProblemSolving")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportProblemSolving ProblemSolving { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportProblemSolving : TeaModel {
                    [NameInMap("Problem")]
                    [Validation(Required=false)]
                    public string Problem { get; set; }

                    [NameInMap("Solution")]
                    [Validation(Required=false)]
                    public string Solution { get; set; }

                    [NameInMap("Solved")]
                    [Validation(Required=false)]
                    public bool? Solved { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                [NameInMap("Satisfaction")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportSatisfaction Satisfaction { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportSatisfaction : TeaModel {
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("SatisfactionDescription")]
                    [Validation(Required=false)]
                    public string SatisfactionDescription { get; set; }

                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                [NameInMap("TodoList")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportTodoList TodoList { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportTodoList : TeaModel {
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    [NameInMap("Tasks")]
                    [Validation(Required=false)]
                    public List<string> Tasks { get; set; }

                }

            }

            [NameInMap("AnalyticsReportReady")]
            [Validation(Required=false)]
            public bool? AnalyticsReportReady { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public long? CallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1332315****</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CalleeLocation")]
            [Validation(Required=false)]
            public string CalleeLocation { get; set; }

            [NameInMap("CallerLocation")]
            [Validation(Required=false)]
            public string CallerLocation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0533128****</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ContactDisposition")]
            [Validation(Required=false)]
            public string ContactDisposition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-10963442671187****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            [NameInMap("ContactType")]
            [Validation(Required=false)]
            public string ContactType { get; set; }

            [NameInMap("CustomerEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataCustomerEvents> CustomerEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataCustomerEvents : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Released</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1532458000000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NotConnected</para>
            /// </summary>
            [NameInMap("EarlyMediaState")]
            [Validation(Required=false)]
            public string EarlyMediaState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("EstablishedTime")]
            [Validation(Required=false)]
            public long? EstablishedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IvrEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataIvrEvents> IvrEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataIvrEvents : TeaModel {
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataIvrEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataIvrEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Route2IVR</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>edaf2eaa-8f88-44ca-812e-41b3cd2b7a90</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MAIN_FLOW</para>
                /// </summary>
                [NameInMap("FlowType")]
                [Validation(Required=false)]
                public string FlowType { get; set; }

            }

            [NameInMap("OutsideNumberReleaseReason")]
            [Validation(Required=false)]
            public string OutsideNumberReleaseReason { get; set; }

            [NameInMap("QueueEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataQueueEvents> QueueEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataQueueEvents : TeaModel {
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataQueueEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataQueueEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Enqueue</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>edaf2eaa-8f88-44ca-812e-41b3cd2b7a90</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public int? QueueType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RecordingReady")]
            [Validation(Required=false)]
            public bool? RecordingReady { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200 - OK</para>
            /// </summary>
            [NameInMap("ReleaseReason")]
            [Validation(Required=false)]
            public string ReleaseReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Satisfaction")]
            [Validation(Required=false)]
            public int? Satisfaction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>IVR</para>
            /// </summary>
            [NameInMap("SatisfactionSurveyChannel")]
            [Validation(Required=false)]
            public string SatisfactionSurveyChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SatisfactionSurveyOffered")]
            [Validation(Required=false)]
            public bool? SatisfactionSurveyOffered { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>skillgroup@ccc-test</para>
            /// </summary>
            [NameInMap("SkillGroupIds")]
            [Validation(Required=false)]
            public string SkillGroupIds { get; set; }

            [NameInMap("SkillGroupNames")]
            [Validation(Required=false)]
            public string SkillGroupNames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7BEEA660-A45A-45E3-98CC-AFC65E715C23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
