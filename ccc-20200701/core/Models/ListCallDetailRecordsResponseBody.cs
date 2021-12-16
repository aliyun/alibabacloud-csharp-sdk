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
                public string AdditionalBroker { get; set; }
                public string AgentIds { get; set; }
                public string AgentNames { get; set; }
                public string Broker { get; set; }
                public string CallDuration { get; set; }
                public string CalledNumber { get; set; }
                public string CalleeLocation { get; set; }
                public string CallerLocation { get; set; }
                public string CallingNumber { get; set; }
                public string ContactDisposition { get; set; }
                public string ContactId { get; set; }
                public string ContactType { get; set; }
                public string EarlyMediaState { get; set; }
                public long? EstablishedTime { get; set; }
                public string InstanceId { get; set; }
                public long? IvrTime { get; set; }
                public long? QueueTime { get; set; }
                public long? RecordingDuration { get; set; }
                public bool? RecordingReady { get; set; }
                public string ReleaseInitiator { get; set; }
                public long? ReleaseTime { get; set; }
                public long? RingTime { get; set; }
                public string SatisfactionDescription { get; set; }
                public int? SatisfactionIndex { get; set; }
                public string SatisfactionSurveyChannel { get; set; }
                public bool? SatisfactionSurveyOffered { get; set; }
                public string SkillGroupIds { get; set; }
                public string SkillGroupNames { get; set; }
                public long? StartTime { get; set; }
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
        };

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
