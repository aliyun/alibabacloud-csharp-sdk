// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCallDetailRecordsResponseBodyData Data { get; set; }
        public class ListCallDetailRecordsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCallDetailRecordsResponseBodyDataList> List { get; set; }
            public class ListCallDetailRecordsResponseBodyDataList : TeaModel {
                [NameInMap("AdditionalBroker")]
                [Validation(Required=false)]
                public string AdditionalBroker { get; set; }

                [NameInMap("AgentIds")]
                [Validation(Required=false)]
                public string AgentIds { get; set; }

                [NameInMap("AgentNames")]
                [Validation(Required=false)]
                public string AgentNames { get; set; }

                [NameInMap("Broker")]
                [Validation(Required=false)]
                public string Broker { get; set; }

                [NameInMap("CallDuration")]
                [Validation(Required=false)]
                public string CallDuration { get; set; }

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

                [NameInMap("DialingTime")]
                [Validation(Required=false)]
                public long? DialingTime { get; set; }

                [NameInMap("EarlyMediaState")]
                [Validation(Required=false)]
                public string EarlyMediaState { get; set; }

                [NameInMap("EstablishedTime")]
                [Validation(Required=false)]
                public long? EstablishedTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IvrTime")]
                [Validation(Required=false)]
                public long? IvrTime { get; set; }

                [NameInMap("QueueTime")]
                [Validation(Required=false)]
                public long? QueueTime { get; set; }

                [NameInMap("RecordingDuration")]
                [Validation(Required=false)]
                public long? RecordingDuration { get; set; }

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

                [NameInMap("RingTime")]
                [Validation(Required=false)]
                public long? RingTime { get; set; }

                [NameInMap("SatisfactionDescription")]
                [Validation(Required=false)]
                public string SatisfactionDescription { get; set; }

                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public int? SatisfactionIndex { get; set; }

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

                [NameInMap("TalkTime")]
                [Validation(Required=false)]
                public long? TalkTime { get; set; }

                [NameInMap("WaitTime")]
                [Validation(Required=false)]
                public long? WaitTime { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
