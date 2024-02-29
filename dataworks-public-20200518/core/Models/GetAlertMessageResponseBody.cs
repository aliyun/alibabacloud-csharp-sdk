// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetAlertMessageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAlertMessageResponseBodyData Data { get; set; }
        public class GetAlertMessageResponseBodyData : TeaModel {
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            [NameInMap("AlertMessageStatus")]
            [Validation(Required=false)]
            public string AlertMessageStatus { get; set; }

            [NameInMap("AlertMethod")]
            [Validation(Required=false)]
            public string AlertMethod { get; set; }

            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            [NameInMap("AlertUser")]
            [Validation(Required=false)]
            public string AlertUser { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataInstances> Instances { get; set; }
            public class GetAlertMessageResponseBodyDataInstances : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataNodes> Nodes { get; set; }
            public class GetAlertMessageResponseBodyDataNodes : TeaModel {
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            [NameInMap("RemindId")]
            [Validation(Required=false)]
            public long? RemindId { get; set; }

            [NameInMap("RemindName")]
            [Validation(Required=false)]
            public string RemindName { get; set; }

            [NameInMap("SlaAlert")]
            [Validation(Required=false)]
            public GetAlertMessageResponseBodyDataSlaAlert SlaAlert { get; set; }
            public class GetAlertMessageResponseBodyDataSlaAlert : TeaModel {
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                [NameInMap("BaselineOwner")]
                [Validation(Required=false)]
                public string BaselineOwner { get; set; }

                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetAlertMessageResponseBodyDataTopics> Topics { get; set; }
            public class GetAlertMessageResponseBodyDataTopics : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

                [NameInMap("TopicOwner")]
                [Validation(Required=false)]
                public string TopicOwner { get; set; }

                [NameInMap("TopicStatus")]
                [Validation(Required=false)]
                public string TopicStatus { get; set; }

            }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
