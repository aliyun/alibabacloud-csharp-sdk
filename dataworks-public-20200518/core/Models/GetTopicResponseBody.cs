// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicResponseBody : TeaModel {
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicResponseBodyData Data { get; set; }
        public class GetTopicResponseBodyData : TeaModel {
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }
            [NameInMap("BaselineStatus")]
            [Validation(Required=false)]
            public string BaselineStatus { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("NextAlertTime")]
            [Validation(Required=false)]
            public long? NextAlertTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public long? FixTime { get; set; }
            [NameInMap("BaselineInGroupId")]
            [Validation(Required=false)]
            public int? BaselineInGroupId { get; set; }
            [NameInMap("BaselineBuffer")]
            [Validation(Required=false)]
            public long? BaselineBuffer { get; set; }
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }
            [NameInMap("TopicStatus")]
            [Validation(Required=false)]
            public string TopicStatus { get; set; }
            [NameInMap("HappenTime")]
            [Validation(Required=false)]
            public long? HappenTime { get; set; }
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }
            [NameInMap("DealUser")]
            [Validation(Required=false)]
            public string DealUser { get; set; }
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }
            [NameInMap("Buffer")]
            [Validation(Required=false)]
            public long? Buffer { get; set; }
            [NameInMap("Assigner")]
            [Validation(Required=false)]
            public string Assigner { get; set; }
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }
        };

    }

}
