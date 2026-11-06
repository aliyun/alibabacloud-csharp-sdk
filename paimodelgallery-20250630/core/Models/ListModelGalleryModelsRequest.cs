// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class ListModelGalleryModelsRequest : TeaModel {
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public string Collections { get; set; }

        [NameInMap("Compressible")]
        [Validation(Required=false)]
        public bool? Compressible { get; set; }

        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ListModelGalleryModelsRequestConditions> Conditions { get; set; }
        public class ListModelGalleryModelsRequestConditions : TeaModel {
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Distillation</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Evaluable")]
        [Validation(Required=false)]
        public bool? Evaluable { get; set; }

        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public bool? FunctionCall { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("ModelSeries")]
        [Validation(Required=false)]
        public string ModelSeries { get; set; }

        [NameInMap("ModelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("SupportedCompressionResource")]
        [Validation(Required=false)]
        public string SupportedCompressionResource { get; set; }

        [NameInMap("SupportedDistillationResource")]
        [Validation(Required=false)]
        public string SupportedDistillationResource { get; set; }

        [NameInMap("SupportedEvaluationResource")]
        [Validation(Required=false)]
        public string SupportedEvaluationResource { get; set; }

        [NameInMap("SupportedInferenceResource")]
        [Validation(Required=false)]
        public string SupportedInferenceResource { get; set; }

        [NameInMap("SupportedTrainingResource")]
        [Validation(Required=false)]
        public string SupportedTrainingResource { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListModelGalleryModelsRequestTag> Tag { get; set; }
        public class ListModelGalleryModelsRequestTag : TeaModel {
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
