// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobOutputModelsResponseBody : TeaModel {
        [NameInMap("OutputModels")]
        [Validation(Required=false)]
        public List<ListTrainingJobOutputModelsResponseBodyOutputModels> OutputModels { get; set; }
        public class ListTrainingJobOutputModelsResponseBodyOutputModels : TeaModel {
            [NameInMap("CompressionSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> CompressionSpec { get; set; }

            [NameInMap("EvaluationSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> EvaluationSpec { get; set; }

            [NameInMap("InferenceSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> InferenceSpec { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListTrainingJobOutputModelsResponseBodyOutputModelsLabels> Labels { get; set; }
            public class ListTrainingJobOutputModelsResponseBodyOutputModelsLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metrics { get; set; }

            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("TrainingSpec")]
            [Validation(Required=false)]
            public Dictionary<string, object> TrainingSpec { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

    }

}
