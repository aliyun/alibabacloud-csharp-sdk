// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsV2ResponseBody : TeaModel {
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
        public ListCallDetailRecordsV2ResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsV2ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of call records.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsV2ResponseBodyDataList> List { get; set; }
            public class ListCallDetailRecordsV2ResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The channel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8f6bcbad-6e2d-4ca3-9b65-91cf0aafdf00</para>
                /// </summary>
                [NameInMap("AccessChannelId")]
                [Validation(Required=false)]
                public string AccessChannelId { get; set; }

                /// <summary>
                /// <para>The channel name. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestChannel</para>
                /// </summary>
                [NameInMap("AccessChannelName")]
                [Validation(Required=false)]
                public string AccessChannelName { get; set; }

                /// <summary>
                /// <para>The channel type. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Web</para>
                /// </summary>
                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                /// <summary>
                /// <para>The visitor ID. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-user-id</para>
                /// </summary>
                [NameInMap("AccessChannelUserId")]
                [Validation(Required=false)]
                public string AccessChannelUserId { get; set; }

                /// <summary>
                /// <para>The visitor name. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestVisitor</para>
                /// </summary>
                [NameInMap("AccessChannelUserName")]
                [Validation(Required=false)]
                public string AccessChannelUserName { get; set; }

                /// <summary>
                /// <para>The additional intermediate number, which may be used in dual-call scenarios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("AdditionalBroker")]
                [Validation(Required=false)]
                public string AdditionalBroker { get; set; }

                /// <summary>
                /// <para>The list of agent IDs. Multiple values are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                /// <summary>
                /// <para>The list of agent names involved in the call. Multiple agents are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudCallCenterTestAgent</para>
                /// </summary>
                [NameInMap("AgentNames")]
                [Validation(Required=false)]
                public string AgentNames { get; set; }

                /// <summary>
                /// <para>The post-call analytics report.</para>
                /// </summary>
                [NameInMap("AnalyticsReport")]
                [Validation(Required=false)]
                public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReport AnalyticsReport { get; set; }
                public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReport : TeaModel {
                    /// <summary>
                    /// <para>The emotion analysis.</para>
                    /// </summary>
                    [NameInMap("Emotion")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportEmotion Emotion { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportEmotion : TeaModel {
                        /// <summary>
                        /// <para>The confidence level.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("Confidence")]
                        [Validation(Required=false)]
                        public int? Confidence { get; set; }

                        /// <summary>
                        /// <para>The detailed remark of the emotion analysis.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>No emotional change from the customer</para>
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the call was successful.</para>
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

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0ff07fe35670423089dbdf12766d962f</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        /// <summary>
                        /// <para>The emotion type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Neutral</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The problem resolution status.</para>
                    /// </summary>
                    [NameInMap("ProblemSolving")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportProblemSolving ProblemSolving { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportProblemSolving : TeaModel {
                        /// <summary>
                        /// <para>The problem description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Alert issue</para>
                        /// </summary>
                        [NameInMap("Problem")]
                        [Validation(Required=false)]
                        public string Problem { get; set; }

                        /// <summary>
                        /// <para>The Solutions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The enrichment service automatically closes the original alert</para>
                        /// </summary>
                        [NameInMap("Solution")]
                        [Validation(Required=false)]
                        public string Solution { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the problem is resolved.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Solved")]
                        [Validation(Required=false)]
                        public bool? Solved { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the call was successful.</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: Successful.</description></item>
                        /// <item><description><b>false</b>: Failed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8bf18b7a10064b29a75946a8d5b8469a</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                    }

                    /// <summary>
                    /// <para>The satisfaction analysis.</para>
                    /// </summary>
                    [NameInMap("Satisfaction")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportSatisfaction Satisfaction { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportSatisfaction : TeaModel {
                        /// <summary>
                        /// <para>The detailed remark of the satisfaction analysis.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>The customer expressed satisfaction</para>
                        /// </summary>
                        [NameInMap("Remark")]
                        [Validation(Required=false)]
                        public string Remark { get; set; }

                        /// <summary>
                        /// <para>The satisfaction description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Satisfied</para>
                        /// </summary>
                        [NameInMap("SatisfactionDescription")]
                        [Validation(Required=false)]
                        public string SatisfactionDescription { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the call was successful.</para>
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

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cb67479ce28243b28ff39948feaa0806</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                    }

                    /// <summary>
                    /// <para>The to-do list.</para>
                    /// </summary>
                    [NameInMap("TodoList")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportTodoList TodoList { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportTodoList : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the call was successful.</para>
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

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cb67479ce28243b28ff39948feaa0806</para>
                        /// </summary>
                        [NameInMap("TaskId")]
                        [Validation(Required=false)]
                        public string TaskId { get; set; }

                        /// <summary>
                        /// <para>The to-do items.</para>
                        /// </summary>
                        [NameInMap("Tasks")]
                        [Validation(Required=false)]
                        public List<string> Tasks { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the AI post-call analytics report is complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AnalyticsReportReady")]
                [Validation(Required=false)]
                public bool? AnalyticsReportReady { get; set; }

                /// <summary>
                /// <para>The intermediate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>053xxxx3127</para>
                /// </summary>
                [NameInMap("Broker")]
                [Validation(Required=false)]
                public string Broker { get; set; }

                /// <summary>
                /// <para>The call duration. For inbound calls, timing starts when the call enters the IVR. For outbound calls, timing starts when the call is connected. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

                /// <summary>
                /// <para>The list of SIP CallIds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dxxx1sdf,xkkwwwa</para>
                /// </summary>
                [NameInMap("CallIds")]
                [Validation(Required=false)]
                public string CallIds { get; set; }

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
                /// <para>The location of the callee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shandong-Jinan</para>
                /// </summary>
                [NameInMap("CalleeLocation")]
                [Validation(Required=false)]
                public string CalleeLocation { get; set; }

                /// <summary>
                /// <para>The location of the caller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing-Beijing</para>
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
                /// <para>The visitor client application name. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Unknown</para>
                /// </summary>
                [NameInMap("ClientAppName")]
                [Validation(Required=false)]
                public string ClientAppName { get; set; }

                /// <summary>
                /// <para>The visitor client IP address. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.100.2.1</para>
                /// </summary>
                [NameInMap("ClientIpAddress")]
                [Validation(Required=false)]
                public string ClientIpAddress { get; set; }

                /// <summary>
                /// <para>The visitor client location. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ClientLocation")]
                [Validation(Required=false)]
                public string ClientLocation { get; set; }

                /// <summary>
                /// <para>The visitor client user agent information. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36</para>
                /// </summary>
                [NameInMap("ClientUserAgent")]
                [Validation(Required=false)]
                public string ClientUserAgent { get; set; }

                /// <summary>
                /// <para>The call end reason. For the enumeration list, refer to the ContactDispositionList query parameter.</para>
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
                /// <para>job-2255019651513856</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <para>The call type. For the enumeration list, refer to the ContactTypeList query parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("ContactType")]
                [Validation(Required=false)]
                public string ContactType { get; set; }

                /// <summary>
                /// <para>The dialing duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                /// <summary>
                /// <para>The early media state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NotConnected</para>
                /// </summary>
                [NameInMap("EarlyMediaState")]
                [Validation(Required=false)]
                public string EarlyMediaState { get; set; }

                /// <summary>
                /// <para>The early media text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Currently on a call</para>
                /// </summary>
                [NameInMap("EarlyMediaText")]
                [Validation(Required=false)]
                public string EarlyMediaText { get; set; }

                /// <summary>
                /// <para>The time when the call was established. If the call was not established, this value is empty. The value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("EstablishedTime")]
                [Validation(Required=false)]
                public long? EstablishedTime { get; set; }

                /// <summary>
                /// <para>The time taken for the agent to first respond to the customer message. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FirstResponseTime")]
                [Validation(Required=false)]
                public long? FirstResponseTime { get; set; }

                /// <summary>
                /// <para>The hold time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("HeldTime")]
                [Validation(Required=false)]
                public long? HeldTime { get; set; }

                /// <summary>
                /// <para>The call center instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The IVR duration, which is the time from when the call enters the IVR to when it starts entering the manual service queue (or the customer abandons the call). Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("IvrTime")]
                [Validation(Required=false)]
                public long? IvrTime { get; set; }

                /// <summary>
                /// <para>The media type.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AUDIO: Voice.</description></item>
                /// <item><description>CHAT: Message.</description></item>
                /// <item><description>VIDEO: Video.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CHAT</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The total number of messages. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MessagesSent")]
                [Validation(Required=false)]
                public long? MessagesSent { get; set; }

                /// <summary>
                /// <para>The total number of messages sent by the agent. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MessagesSentByAgent")]
                [Validation(Required=false)]
                public long? MessagesSentByAgent { get; set; }

                /// <summary>
                /// <para>The total number of messages sent by the customer. This parameter has a value only when MediaType is CHAT.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? MessagesSentByCustomer { get; set; }

                /// <summary>
                /// <para>The list of off-site agent IDs involved in the call. Multiple agents are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skg-default@ccc-test</para>
                /// </summary>
                [NameInMap("OffSiteAgentIds")]
                [Validation(Required=false)]
                public string OffSiteAgentIds { get; set; }

                /// <summary>
                /// <para>The off-site agent number that is called when the assigned agent is an off-site agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80312348</para>
                /// </summary>
                [NameInMap("OffsiteAgentDestinationNumbers")]
                [Validation(Required=false)]
                public string OffsiteAgentDestinationNumbers { get; set; }

                /// <summary>
                /// <para>The number that initiates the call to the off-site agent when the assigned agent is an off-site agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0101257****</para>
                /// </summary>
                [NameInMap("OffsiteAgentOriginatorNumbers")]
                [Validation(Required=false)]
                public string OffsiteAgentOriginatorNumbers { get; set; }

                /// <summary>
                /// <para>The hangup reason of the last assigned offsite agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IVRException</para>
                /// </summary>
                [NameInMap("OffsiteAgentReleaseReason")]
                [Validation(Required=false)]
                public string OffsiteAgentReleaseReason { get; set; }

                /// <summary>
                /// <para>The called number when the call is transferred to an outside line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>134xxxxxx</para>
                /// </summary>
                [NameInMap("OutsideNumberDestinationNumber")]
                [Validation(Required=false)]
                public string OutsideNumberDestinationNumber { get; set; }

                /// <summary>
                /// <para>The hangup reason when the call is transferred to an outside line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoAnswer</para>
                /// </summary>
                [NameInMap("OutsideNumberReleaseReason")]
                [Validation(Required=false)]
                public string OutsideNumberReleaseReason { get; set; }

                /// <summary>
                /// <para>The queue duration, which is the time from when the call enters the manual service queue to when the agent starts ringing (or the customer abandons the call, the queue times out, or the queue overflows). Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <para>The recording duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

                /// <summary>
                /// <para>Indicates whether the recording has been generated. If the call was not established, false is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("RecordingReady")]
                [Validation(Required=false)]
                public bool? RecordingReady { get; set; }

                /// <summary>
                /// <para>The party that hung up.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>agent: The agent.</description></item>
                /// <item><description>customer: The customer.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>customer</para>
                /// </summary>
                [NameInMap("ReleaseInitiator")]
                [Validation(Required=false)]
                public string ReleaseInitiator { get; set; }

                /// <summary>
                /// <para>The hangup reason of the call channel, indicating why the current call channel was hung up. The value is a response code defined in the SIP protocol. Refer to the SIP protocol to analyze the hangup reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>486:USER_BUSY</para>
                /// </summary>
                [NameInMap("ReleaseReason")]
                [Validation(Required=false)]
                public string ReleaseReason { get; set; }

                /// <summary>
                /// <para>The time when the call ended, in Unix timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1532707199000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <para>The ringing duration, which is the time from when the agent starts ringing to when the agent answers (or the customer abandons the call). Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                /// <summary>
                /// <para>The satisfaction description, which corresponds to the configuration of the satisfaction module in the satisfaction IVR and is defined by the customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Satisfied</para>
                /// </summary>
                [NameInMap("SatisfactionDescription")]
                [Validation(Required=false)]
                public string SatisfactionDescription { get; set; }

                /// <summary>
                /// <para>The satisfaction rating, which is the value of the satisfaction key digit (a single digit).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public int? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>The satisfaction survey channel.</para>
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
                /// <para>The skill group IDs of the agents who participated in the call. Multiple skill groups are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skg-default@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                /// <summary>
                /// <para>The skill group names of the agents who participated in the call. Multiple skill groups are separated by commas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestSkillGroup1,TestSkillGroup2</para>
                /// </summary>
                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

                /// <summary>
                /// <para>The time when the call started. For inbound calls, this is counted from when the call enters the IVR. For outbound calls, this is counted from when dialing begins. The value is in Unix timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The summary index.</para>
                /// </summary>
                [NameInMap("SummaryIndex")]
                [Validation(Required=false)]
                public ListCallDetailRecordsV2ResponseBodyDataListSummaryIndex SummaryIndex { get; set; }
                public class ListCallDetailRecordsV2ResponseBodyDataListSummaryIndex : TeaModel {
                    /// <summary>
                    /// <para>The keywords.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CustomerService</para>
                    /// </summary>
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public string Keywords { get; set; }

                }

                /// <summary>
                /// <para>The talk time. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                /// <summary>
                /// <para>The number of transfers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TransferCount")]
                [Validation(Required=false)]
                public long? TransferCount { get; set; }

                /// <summary>
                /// <para>The outbound called number carried when the call is transferred from an intelligent outbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>134xxxxxx</para>
                /// </summary>
                [NameInMap("VoicebotDestinationNumber")]
                [Validation(Required=false)]
                public string VoicebotDestinationNumber { get; set; }

                /// <summary>
                /// <para>The outbound caller number carried when the call is transferred from an intelligent outbound call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>021xxxxxxx</para>
                /// </summary>
                [NameInMap("VoicebotOriginatorNumber")]
                [Validation(Required=false)]
                public string VoicebotOriginatorNumber { get; set; }

                /// <summary>
                /// <para>The customer wait time, which equals QueueTime + RingTime. If the customer abandons the call during the waiting period, the value is 0. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public long? WaitTime { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>01B12EE4-6AF2-4730-8B78-EC15F4E5C025</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
