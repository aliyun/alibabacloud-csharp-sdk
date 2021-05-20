// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineKeyPathResponseBody : TeaModel {
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
        public List<GetBaselineKeyPathResponseBodyData> Data { get; set; }
        public class GetBaselineKeyPathResponseBodyData : TeaModel {
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("PrgType")]
            [Validation(Required=false)]
            public int? PrgType { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            [NameInMap("InGroupId")]
            [Validation(Required=false)]
            public int? InGroupId { get; set; }

            [NameInMap("Runs")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataRuns> Runs { get; set; }
            public class GetBaselineKeyPathResponseBodyDataRuns : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("AbsTime")]
                [Validation(Required=false)]
                public long? AbsTime { get; set; }

                [NameInMap("BeginRunningTime")]
                [Validation(Required=false)]
                public long? BeginRunningTime { get; set; }

                [NameInMap("CycTime")]
                [Validation(Required=false)]
                public long? CycTime { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("BeginCast")]
                [Validation(Required=false)]
                public long? BeginCast { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("EndCast")]
                [Validation(Required=false)]
                public long? EndCast { get; set; }

                [NameInMap("BeginWaitResTime")]
                [Validation(Required=false)]
                public long? BeginWaitResTime { get; set; }

                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                [NameInMap("BeginWaitTimeTime")]
                [Validation(Required=false)]
                public long? BeginWaitTimeTime { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

            }

            [NameInMap("Topics")]
            [Validation(Required=false)]
            public List<GetBaselineKeyPathResponseBodyDataTopics> Topics { get; set; }
            public class GetBaselineKeyPathResponseBodyDataTopics : TeaModel {
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public long? TopicName { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                [NameInMap("AddTime")]
                [Validation(Required=false)]
                public long? AddTime { get; set; }

            }

        }

    }

}
