// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetTrainAlgorithResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrainAlgorithResponseBodyData Data { get; set; }
        public class GetTrainAlgorithResponseBodyData : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("AlgorithmType")]
            [Validation(Required=false)]
            public string AlgorithmType { get; set; }
            [NameInMap("TrainSampleCount")]
            [Validation(Required=false)]
            public long? TrainSampleCount { get; set; }
            [NameInMap("TestSampleCount")]
            [Validation(Required=false)]
            public long? TestSampleCount { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("TrainStatus")]
            [Validation(Required=false)]
            public string TrainStatus { get; set; }
            [NameInMap("TrainProgress")]
            [Validation(Required=false)]
            public long? TrainProgress { get; set; }
            [NameInMap("TrainQueueSize")]
            [Validation(Required=false)]
            public long? TrainQueueSize { get; set; }
            [NameInMap("TrainEstimateTime")]
            [Validation(Required=false)]
            public long? TrainEstimateTime { get; set; }
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }
            [NameInMap("ReadyTrain")]
            [Validation(Required=false)]
            public string ReadyTrain { get; set; }
            [NameInMap("DeployVersion")]
            [Validation(Required=false)]
            public string DeployVersion { get; set; }
            [NameInMap("Precision")]
            [Validation(Required=false)]
            public float? Precision { get; set; }
            [NameInMap("Recall")]
            [Validation(Required=false)]
            public float? Recall { get; set; }
            [NameInMap("NoReadyReason")]
            [Validation(Required=false)]
            public string NoReadyReason { get; set; }
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<GetTrainAlgorithResponseBodyDataInstanceList> InstanceList { get; set; }
            public class GetTrainAlgorithResponseBodyDataInstanceList : TeaModel {
                public string InstanceName { get; set; }
                public string InstaceId { get; set; }
                public string ProjectId { get; set; }
            }
        };

    }

}
