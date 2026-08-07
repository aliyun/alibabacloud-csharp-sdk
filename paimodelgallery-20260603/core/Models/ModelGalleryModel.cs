// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class ModelGalleryModel : TeaModel {
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        [NameInMap("Compressible")]
        [Validation(Required=false)]
        public bool? Compressible { get; set; }

        [NameInMap("DeepThink")]
        [Validation(Required=false)]
        public bool? DeepThink { get; set; }

        [NameInMap("Demonstrable")]
        [Validation(Required=false)]
        public bool? Demonstrable { get; set; }

        [NameInMap("Deployable")]
        [Validation(Required=false)]
        public bool? Deployable { get; set; }

        [NameInMap("Distillable")]
        [Validation(Required=false)]
        public bool? Distillable { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Evaluable")]
        [Validation(Required=false)]
        public bool? Evaluable { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public bool? FunctionCall { get; set; }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtLatestVersionModified")]
        [Validation(Required=false)]
        public string GmtLatestVersionModified { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("LatestVersionName")]
        [Validation(Required=false)]
        public string LatestVersionName { get; set; }

        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        [NameInMap("ModelDoc")]
        [Validation(Required=false)]
        public string ModelDoc { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("ModelSeries")]
        [Validation(Required=false)]
        public string ModelSeries { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        [NameInMap("ParameterSize")]
        [Validation(Required=false)]
        public long? ParameterSize { get; set; }

        [NameInMap("SearchWords")]
        [Validation(Required=false)]
        public string SearchWords { get; set; }

        [NameInMap("SupportedCompressionMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedCompressionMethods { get; set; }

        [NameInMap("SupportedCompressionResources")]
        [Validation(Required=false)]
        public string SupportedCompressionResources { get; set; }

        [NameInMap("SupportedDistillationMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedDistillationMethods { get; set; }

        [NameInMap("SupportedDistillationResources")]
        [Validation(Required=false)]
        public string SupportedDistillationResources { get; set; }

        [NameInMap("SupportedEvaluationMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedEvaluationMethods { get; set; }

        [NameInMap("SupportedEvaluationResources")]
        [Validation(Required=false)]
        public string SupportedEvaluationResources { get; set; }

        [NameInMap("SupportedInferenceMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedInferenceMethods { get; set; }

        [NameInMap("SupportedInferenceResources")]
        [Validation(Required=false)]
        public string SupportedInferenceResources { get; set; }

        [NameInMap("SupportedTrainingMethods")]
        [Validation(Required=false)]
        public Dictionary<string, object> SupportedTrainingMethods { get; set; }

        [NameInMap("SupportedTrainingResources")]
        [Validation(Required=false)]
        public string SupportedTrainingResources { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ModelGalleryModelTags Tags { get; set; }
        public class ModelGalleryModelTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        [NameInMap("Trainable")]
        [Validation(Required=false)]
        public bool? Trainable { get; set; }

    }

}
