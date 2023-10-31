// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class DescribeFineTuneJobResponseBody : TeaModel {
        [NameInMap("BaseModel")]
        [Validation(Required=false)]
        public string BaseModel { get; set; }

        [NameInMap("FineTunedModel")]
        [Validation(Required=false)]
        public string FineTunedModel { get; set; }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public DescribeFineTuneJobResponseBodyHyperParameters HyperParameters { get; set; }
        public class DescribeFineTuneJobResponseBodyHyperParameters : TeaModel {
            [NameInMap("BatchSize")]
            [Validation(Required=false)]
            public int? BatchSize { get; set; }

            [NameInMap("Epochs")]
            [Validation(Required=false)]
            public int? Epochs { get; set; }

            [NameInMap("LearningRate")]
            [Validation(Required=false)]
            public string LearningRate { get; set; }

            [NameInMap("PromptLossWeight")]
            [Validation(Required=false)]
            public double? PromptLossWeight { get; set; }

        }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TrainingFiles")]
        [Validation(Required=false)]
        public List<string> TrainingFiles { get; set; }

        [NameInMap("TrainingType")]
        [Validation(Required=false)]
        public string TrainingType { get; set; }

        [NameInMap("ValidationFiles")]
        [Validation(Required=false)]
        public List<string> ValidationFiles { get; set; }

    }

}
