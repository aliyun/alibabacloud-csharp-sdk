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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCallDetailRecordResponseBodyData Data { get; set; }
        public class GetCallDetailRecordResponseBodyData : TeaModel {
            [NameInMap("ReleaseInitiator")]
            [Validation(Required=false)]
            public string ReleaseInitiator { get; set; }
            [NameInMap("ContactDisposition")]
            [Validation(Required=false)]
            public string ContactDisposition { get; set; }
            [NameInMap("ContactType")]
            [Validation(Required=false)]
            public string ContactType { get; set; }
            [NameInMap("AgentIds")]
            [Validation(Required=false)]
            public string AgentIds { get; set; }
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public long? CallDuration { get; set; }
            [NameInMap("RecordingReady")]
            [Validation(Required=false)]
            public bool? RecordingReady { get; set; }
            [NameInMap("EstablishedTime")]
            [Validation(Required=false)]
            public long? EstablishedTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("SatisfactionSurveyOffered")]
            [Validation(Required=false)]
            public bool? SatisfactionSurveyOffered { get; set; }
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }
            [NameInMap("AgentNames")]
            [Validation(Required=false)]
            public string AgentNames { get; set; }
            [NameInMap("Satisfaction")]
            [Validation(Required=false)]
            public int? Satisfaction { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }
            [NameInMap("SatisfactionSurveyChannel")]
            [Validation(Required=false)]
            public string SatisfactionSurveyChannel { get; set; }
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public long? ReleaseTime { get; set; }
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }
            [NameInMap("SkillGroupNames")]
            [Validation(Required=false)]
            public string SkillGroupNames { get; set; }
            [NameInMap("SkillGroupIds")]
            [Validation(Required=false)]
            public string SkillGroupIds { get; set; }
            [NameInMap("AgentEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataAgentEvents> AgentEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataAgentEvents : TeaModel {
                public string AgentName { get; set; }
                public string AgentId { get; set; }
                public string SkillGroupId { get; set; }
                public List<GetCallDetailRecordResponseBodyDataAgentEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataAgentEventsEventSequence : TeaModel {
                    public string Event { get; set; }
                    public long? EventTime { get; set; }
                }
            }
            [NameInMap("IvrEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataIvrEvents> IvrEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataIvrEvents : TeaModel {
                public string FlowId { get; set; }
                public List<GetCallDetailRecordResponseBodyDataIvrEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataIvrEventsEventSequence : TeaModel {
                    public string Event { get; set; }
                    public long? EventTime { get; set; }
                }
            }
            [NameInMap("QueueEvents")]
            [Validation(Required=false)]
            public List<GetCallDetailRecordResponseBodyDataQueueEvents> QueueEvents { get; set; }
            public class GetCallDetailRecordResponseBodyDataQueueEvents : TeaModel {
                public string QueueId { get; set; }
                public string QueueName { get; set; }
                public string FlowId { get; set; }
                public int? QueueType { get; set; }
                public List<GetCallDetailRecordResponseBodyDataQueueEventsEventSequence> EventSequence { get; set; }
                public class GetCallDetailRecordResponseBodyDataQueueEventsEventSequence : TeaModel {
                    public string Event { get; set; }
                    public long? EventTime { get; set; }
                }
            }
            [NameInMap("CallerLocation")]
            [Validation(Required=false)]
            public string CallerLocation { get; set; }
            [NameInMap("CalleeLocation")]
            [Validation(Required=false)]
            public string CalleeLocation { get; set; }
        };

    }

}
