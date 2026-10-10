// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of agent events.</para>
            /// </summary>
            [NameInMap("AgentEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataAgentEvents> AgentEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataAgentEvents : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent Wang</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>The event sequence.</para>
                /// </summary>
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataAgentEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataAgentEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <para>The duration of the event, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <para>The event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Dialing</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the event occurred. The time is formatted as a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

            }

            /// <summary>
            /// <para>The list of agent IDs. This indicates the agents that the call passed through. Multiple values are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent1@ccc-test,agent2@ccc-test</para>
            /// </summary>
            [NameInMap("AgentIds")]
            [Validation(Required=false)]
            public string AgentIds { get; set; }

            /// <summary>
            /// <para>The list of agent names. This indicates the agents that the call passed through. Multiple values are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent1,agent2</para>
            /// </summary>
            [NameInMap("AgentNames")]
            [Validation(Required=false)]
            public string AgentNames { get; set; }

            /// <summary>
            /// <para>The intelligent analysis report of the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;ProblemSolving&quot;:{&quot;Success&quot;:true,&quot;Solved&quot;:true}}</para>
            /// </summary>
            [NameInMap("AnalyticsReport")]
            [Validation(Required=false)]
            public GetCallDetailRecordResponseBodyDataAnalyticsReport AnalyticsReport { get; set; }
            public class GetCallDetailRecordResponseBodyDataAnalyticsReport : TeaModel {
                /// <summary>
                /// <para>The analysis result of customer emotion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Success&quot;:true,&quot;Type&quot;:&quot;Neutral&quot;,&quot;Confidence&quot;:50}</para>
                /// </summary>
                [NameInMap("Emotion")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportEmotion Emotion { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportEmotion : TeaModel {
                    /// <summary>
                    /// <para>The confidence level of customer emotion recognition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public int? Confidence { get; set; }

                    /// <summary>
                    /// <para>The remark for customer emotion analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>No emotion change detected in the customer</para>
                    /// </summary>
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the emotion analysis task is executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    /// <summary>
                    /// <para>The ID of the emotion analysis task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0ff07fe35670423089dbdf12766d962f</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// <para>The customer emotion type identified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Neutral</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The analysis result of problem resolution.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Success&quot;:true,&quot;Solved&quot;:true,&quot;Problem&quot;:&quot;Alert issue&quot;}</para>
                /// </summary>
                [NameInMap("ProblemSolving")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportProblemSolving ProblemSolving { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportProblemSolving : TeaModel {
                    /// <summary>
                    /// <para>The customer problem identified by the analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alert issue</para>
                    /// </summary>
                    [NameInMap("Problem")]
                    [Validation(Required=false)]
                    public string Problem { get; set; }

                    /// <summary>
                    /// <para>The Solutions generated by the analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The enrichment service automatically closes the original alert</para>
                    /// </summary>
                    [NameInMap("Solution")]
                    [Validation(Required=false)]
                    public string Solution { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the customer problem is resolved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Solved")]
                    [Validation(Required=false)]
                    public bool? Solved { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the problem resolution analysis task is executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    /// <summary>
                    /// <para>The ID of the problem resolution analysis task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0ff07fe35670423089dbdf12766d962f</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <para>The analysis result of customer satisfaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Success&quot;:true,&quot;SatisfactionDescription&quot;:&quot;Satisfied&quot;}</para>
                /// </summary>
                [NameInMap("Satisfaction")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportSatisfaction Satisfaction { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportSatisfaction : TeaModel {
                    /// <summary>
                    /// <para>The remark for customer satisfaction analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The customer expressed satisfaction</para>
                    /// </summary>
                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <para>The description of the customer satisfaction analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Satisfied</para>
                    /// </summary>
                    [NameInMap("SatisfactionDescription")]
                    [Validation(Required=false)]
                    public string SatisfactionDescription { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the satisfaction analysis task is executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    /// <summary>
                    /// <para>The ID of the satisfaction analysis task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cb67479ce28243b28ff39948feaa0806</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                }

                /// <summary>
                /// <para>The analysis result of to-do items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Success&quot;:true,&quot;Tasks&quot;:[&quot;Follow-up&quot;]}</para>
                /// </summary>
                [NameInMap("TodoList")]
                [Validation(Required=false)]
                public GetCallDetailRecordResponseBodyDataAnalyticsReportTodoList TodoList { get; set; }
                public class GetCallDetailRecordResponseBodyDataAnalyticsReportTodoList : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the to-do item analysis task is executed successfully.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                    /// <summary>
                    /// <para>The ID of the to-do item analysis task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cb67479ce28243b28ff39948feaa0806</para>
                    /// </summary>
                    [NameInMap("TaskId")]
                    [Validation(Required=false)]
                    public string TaskId { get; set; }

                    /// <summary>
                    /// <para>The list of to-do items generated by the analysis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;Follow-up&quot;]</para>
                    /// </summary>
                    [NameInMap("Tasks")]
                    [Validation(Required=false)]
                    public List<string> Tasks { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the intelligent analysis report is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AnalyticsReportReady")]
            [Validation(Required=false)]
            public bool? AnalyticsReportReady { get; set; }

            /// <summary>
            /// <para>The call duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public long? CallDuration { get; set; }

            /// <summary>
            /// <para>The called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1332315****</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>The location information of the called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hebei Province-Tangshan</para>
            /// </summary>
            [NameInMap("CalleeLocation")]
            [Validation(Required=false)]
            public string CalleeLocation { get; set; }

            /// <summary>
            /// <para>The location information of the calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shandong Province-Zibo</para>
            /// </summary>
            [NameInMap("CallerLocation")]
            [Validation(Required=false)]
            public string CallerLocation { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0533128****</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>The reason why the call ended. Note: Disconnect reasons such as voice mail, transfer to agent failure, queue timeout, queue overflow, and IVR exception are displayed only if the customer configures a disconnect reason node. If the node is not configured and the IVR does not contain a transfer to agent module, the disconnect reason defaults to IVR abandoned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ContactDisposition")]
            [Validation(Required=false)]
            public string ContactDisposition { get; set; }

            /// <summary>
            /// <para>The call ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-10963442671187****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The call type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OUTBOUND</para>
            /// </summary>
            [NameInMap("ContactType")]
            [Validation(Required=false)]
            public string ContactType { get; set; }

            /// <summary>
            /// <para>The list of customer events.</para>
            /// </summary>
            [NameInMap("CustomerEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataCustomerEvents> CustomerEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataCustomerEvents : TeaModel {
                /// <summary>
                /// <para>The customer ID, which is usually the customer phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1332315****</para>
                /// </summary>
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                /// <summary>
                /// <para>The event sequence.</para>
                /// </summary>
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <para>The event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Released</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the event occurred. The time is formatted as a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1532458000000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The early media state. This refers to an exception that occurs during the early media phase, which is usually the phase of calling the customer. An exception in this phase causes the call to fail. Therefore, this state indicates the possible reason for the unanswered call based on the analysis of the early media state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NotConnected</para>
            /// </summary>
            [NameInMap("EarlyMediaState")]
            [Validation(Required=false)]
            public string EarlyMediaState { get; set; }

            /// <summary>
            /// <para>The time when the call was established. If the call was not established, this value is empty. The time is formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("EstablishedTime")]
            [Validation(Required=false)]
            public long? EstablishedTime { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The list of IVR events.</para>
            /// </summary>
            [NameInMap("IvrEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataIvrEvents> IvrEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataIvrEvents : TeaModel {
                /// <summary>
                /// <para>The event sequence.</para>
                /// </summary>
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataIvrEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataIvrEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <para>The event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Route2IVR</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the event occurred. The time is formatted as a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <para>The IVR contact flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edaf2eaa-8f88-44ca-812e-41b3cd2b7a90</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The contact flow type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MAIN_FLOW</para>
                /// </summary>
                [NameInMap("FlowType")]
                [Validation(Required=false)]
                public string FlowType { get; set; }

            }

            /// <summary>
            /// <para>The reason for disconnection when transferring to an external line.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NoAnswer</para>
            /// </summary>
            [NameInMap("OutsideNumberReleaseReason")]
            [Validation(Required=false)]
            public string OutsideNumberReleaseReason { get; set; }

            /// <summary>
            /// <para>The list of queue events.</para>
            /// </summary>
            [NameInMap("QueueEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataQueueEvents> QueueEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataQueueEvents : TeaModel {
                /// <summary>
                /// <para>The event sequence.</para>
                /// </summary>
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataQueueEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataQueueEventsEventSequence : TeaModel {
                    /// <summary>
                    /// <para>The event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Enqueue</para>
                    /// </summary>
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    /// <summary>
                    /// <para>The timestamp when the event occurred. The time is formatted as a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1604639129000</para>
                    /// </summary>
                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                /// <summary>
                /// <para>The contact flow ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>edaf2eaa-8f88-44ca-812e-41b3cd2b7a90</para>
                /// </summary>
                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                /// <summary>
                /// <para>The queue ID. If the queue is a skill group queue, this is the skill group ID. If the queue is an agent personal queue, this is the agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                /// <summary>
                /// <para>The queue name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test skill group</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>The queue type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public int? QueueType { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the recording has been generated. If the call has not been established, false is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RecordingReady")]
            [Validation(Required=false)]
            public bool? RecordingReady { get; set; }

            /// <summary>
            /// <para>The party that disconnected the call.
            /// [_single.resp.200.props.Data.ReleaseInitiator.enum.agent ]The agent.
            /// [_single.resp.200.props.Data.ReleaseInitiator.enum.customer ]The customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            /// <summary>
            /// <para>The reason why the call ended. This is usually in the format of a SIP code followed by a text description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200 - OK</para>
            /// </summary>
            [NameInMap("ReleaseReason")]
            [Validation(Required=false)]
            public string ReleaseReason { get; set; }

            /// <summary>
            /// <para>The end time of the call. This is the time when the last participant in the call hung up. The time is formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            /// <summary>
            /// <para>The satisfaction survey result. The values and meanings of the satisfaction survey are customized by the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Satisfaction")]
            [Validation(Required=false)]
            public int? Satisfaction { get; set; }

            /// <summary>
            /// <para>The channel used to initiate the satisfaction survey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IVR</para>
            /// </summary>
            [NameInMap("SatisfactionSurveyChannel")]
            [Validation(Required=false)]
            public string SatisfactionSurveyChannel { get; set; }

            /// <summary>
            /// <para>Indicates whether a satisfaction survey was sent.</para>
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
            /// <para>Test skill group</para>
            /// </summary>
            [NameInMap("SkillGroupNames")]
            [Validation(Required=false)]
            public string SkillGroupNames { get; set; }

            /// <summary>
            /// <para>The start time of the call. For inbound calls, the time is calculated from when the call enters the IVR. For outbound calls, the time is calculated from when the call starts to connect. The time is formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1532458000000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BEEA660-A45A-45E3-98CC-AFC65E715C23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
