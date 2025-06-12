// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsV2ResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallDetailRecordsV2ResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsV2ResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsV2ResponseBodyDataList> List { get; set; }
            public class ListCallDetailRecordsV2ResponseBodyDataList : TeaModel {
                [NameInMap("AccessChannelName")]
                [Validation(Required=false)]
                public string AccessChannelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Web</para>
                /// </summary>
                [NameInMap("AccessChannelType")]
                [Validation(Required=false)]
                public string AccessChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-user-id</para>
                /// </summary>
                [NameInMap("AccessChannelUserId")]
                [Validation(Required=false)]
                public string AccessChannelUserId { get; set; }

                [NameInMap("AccessChannelUserName")]
                [Validation(Required=false)]
                public string AccessChannelUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0533128****</para>
                /// </summary>
                [NameInMap("AdditionalBroker")]
                [Validation(Required=false)]
                public string AdditionalBroker { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                [NameInMap("AgentNames")]
                [Validation(Required=false)]
                public string AgentNames { get; set; }

                [NameInMap("AnalyticsReport")]
                [Validation(Required=false)]
                public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReport AnalyticsReport { get; set; }
                public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReport : TeaModel {
                    [NameInMap("Emotion")]
                    [Validation(Required=false)]
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportEmotion Emotion { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportEmotion : TeaModel {
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
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportProblemSolving ProblemSolving { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportProblemSolving : TeaModel {
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
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportSatisfaction Satisfaction { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportSatisfaction : TeaModel {
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
                    public ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportTodoList TodoList { get; set; }
                    public class ListCallDetailRecordsV2ResponseBodyDataListAnalyticsReportTodoList : TeaModel {
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
                /// <para>053xxxx3127</para>
                /// </summary>
                [NameInMap("Broker")]
                [Validation(Required=false)]
                public string Broker { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

                [NameInMap("CallIds")]
                [Validation(Required=false)]
                public string CallIds { get; set; }

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

                [NameInMap("ClientAppName")]
                [Validation(Required=false)]
                public string ClientAppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.100.2.1</para>
                /// </summary>
                [NameInMap("ClientIpAddress")]
                [Validation(Required=false)]
                public string ClientIpAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("ClientLocation")]
                [Validation(Required=false)]
                public string ClientLocation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36</para>
                /// </summary>
                [NameInMap("ClientUserAgent")]
                [Validation(Required=false)]
                public string ClientUserAgent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("ContactDisposition")]
                [Validation(Required=false)]
                public string ContactDisposition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>job-2255019651513856</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OUTBOUND</para>
                /// </summary>
                [NameInMap("ContactType")]
                [Validation(Required=false)]
                public string ContactType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NotConnected</para>
                /// </summary>
                [NameInMap("EarlyMediaState")]
                [Validation(Required=false)]
                public string EarlyMediaState { get; set; }

                [NameInMap("EarlyMediaText")]
                [Validation(Required=false)]
                public string EarlyMediaText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532448000000</para>
                /// </summary>
                [NameInMap("EstablishedTime")]
                [Validation(Required=false)]
                public long? EstablishedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FirstResponseTime")]
                [Validation(Required=false)]
                public long? FirstResponseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("HeldTime")]
                [Validation(Required=false)]
                public long? HeldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("IvrTime")]
                [Validation(Required=false)]
                public long? IvrTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CHAT</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MessagesSent")]
                [Validation(Required=false)]
                public long? MessagesSent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MessagesSentByAgent")]
                [Validation(Required=false)]
                public long? MessagesSentByAgent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? MessagesSentByCustomer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>skg-default@ccc-test</para>
                /// </summary>
                [NameInMap("OffSiteAgentIds")]
                [Validation(Required=false)]
                public string OffSiteAgentIds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>80312348</para>
                /// </summary>
                [NameInMap("OffsiteAgentDestinationNumbers")]
                [Validation(Required=false)]
                public string OffsiteAgentDestinationNumbers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0101257****</para>
                /// </summary>
                [NameInMap("OffsiteAgentOriginatorNumbers")]
                [Validation(Required=false)]
                public string OffsiteAgentOriginatorNumbers { get; set; }

                [NameInMap("OutsideNumberReleaseReason")]
                [Validation(Required=false)]
                public string OutsideNumberReleaseReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

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
                /// <para>486:USER_BUSY</para>
                /// </summary>
                [NameInMap("ReleaseReason")]
                [Validation(Required=false)]
                public string ReleaseReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1532707199000</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public long? ReleaseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                [NameInMap("SatisfactionDescription")]
                [Validation(Required=false)]
                public string SatisfactionDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public int? SatisfactionIndex { get; set; }

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
                /// <para>skg-default@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1631440860000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("SummaryIndex")]
                [Validation(Required=false)]
                public ListCallDetailRecordsV2ResponseBodyDataListSummaryIndex SummaryIndex { get; set; }
                public class ListCallDetailRecordsV2ResponseBodyDataListSummaryIndex : TeaModel {
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public string Keywords { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TransferCount")]
                [Validation(Required=false)]
                public long? TransferCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public long? WaitTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>01B12EE4-6AF2-4730-8B78-EC15F4E5C025</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
