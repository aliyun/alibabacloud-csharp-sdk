// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetCallDetailRecordResponseBody : TeaModel {
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
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

            }

            [NameInMap("AgentIds")]
            [Validation(Required=false)]
            public string AgentIds { get; set; }

            [NameInMap("AgentNames")]
            [Validation(Required=false)]
            public string AgentNames { get; set; }

            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public long? CallDuration { get; set; }

            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CalleeLocation")]
            [Validation(Required=false)]
            public string CalleeLocation { get; set; }

            [NameInMap("CallerLocation")]
            [Validation(Required=false)]
            public string CallerLocation { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            [NameInMap("ContactDisposition")]
            [Validation(Required=false)]
            public string ContactDisposition { get; set; }

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
                [NameInMap("CustomerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataCustomerEventsEventSequence : TeaModel {
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

            }

            [NameInMap("EarlyMediaState")]
            [Validation(Required=false)]
            public string EarlyMediaState { get; set; }

            [NameInMap("EstablishedTime")]
            [Validation(Required=false)]
            public long? EstablishedTime { get; set; }

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
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("FlowType")]
                [Validation(Required=false)]
                public string FlowType { get; set; }

            }

            [NameInMap("QueueEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataQueueEvents> QueueEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataQueueEvents : TeaModel {
                [NameInMap("EventSequence")]
                [Validation(Required=false)]
                public List<GetCallDetailRecordResponseBodyDataQueueEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataQueueEventsEventSequence : TeaModel {
                    [NameInMap("Event")]
                    [Validation(Required=false)]
                    public string Event { get; set; }

                    [NameInMap("EventTime")]
                    [Validation(Required=false)]
                    public long? EventTime { get; set; }

                }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public string QueueId { get; set; }

                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                [NameInMap("QueueType")]
                [Validation(Required=false)]
                public int? QueueType { get; set; }

            }

            [NameInMap("RecordingReady")]
            [Validation(Required=false)]
            public bool? RecordingReady { get; set; }

            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }

            [NameInMap("ReleaseReason")]
            [Validation(Required=false)]
            public string ReleaseReason { get; set; }

            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }

            [NameInMap("Satisfaction")]
            [Validation(Required=false)]
            public int? Satisfaction { get; set; }

            [NameInMap("SatisfactionSurveyChannel")]
            [Validation(Required=false)]
            public string SatisfactionSurveyChannel { get; set; }

            [NameInMap("SatisfactionSurveyOffered")]
            [Validation(Required=false)]
            public bool? SatisfactionSurveyOffered { get; set; }

            [NameInMap("SkillGroupIds")]
            [Validation(Required=false)]
            public string SkillGroupIds { get; set; }

            [NameInMap("SkillGroupNames")]
            [Validation(Required=false)]
            public string SkillGroupNames { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
