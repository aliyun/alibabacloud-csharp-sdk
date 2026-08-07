// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class ListModelGalleryModelsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>QuickStart</para>
        /// </summary>
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public string Collections { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Compressible")]
        [Validation(Required=false)]
        public bool? Compressible { get; set; }

        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ListModelGalleryModelsRequestConditions> Conditions { get; set; }
        public class ListModelGalleryModelsRequestConditions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ParameterSize</para>
            /// </summary>
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LessThan</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeepThink")]
        [Validation(Required=false)]
        public bool? DeepThink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Demonstrable")]
        [Validation(Required=false)]
        public bool? Demonstrable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Deployable")]
        [Validation(Required=false)]
        public bool? Deployable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Distillable")]
        [Validation(Required=false)]
        public bool? Distillable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aigc</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Evaluable")]
        [Validation(Required=false)]
        public bool? Evaluable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FunctionCall")]
        [Validation(Required=false)]
        public bool? FunctionCall { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen3-235B-A22B-Thinking-2507</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen</para>
        /// </summary>
        [NameInMap("ModelSeries")]
        [Validation(Required=false)]
        public string ModelSeries { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LoRA</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>Qwen</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedCompressionResource")]
        [Validation(Required=false)]
        public string SupportedCompressionResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedDistillationResource")]
        [Validation(Required=false)]
        public string SupportedDistillationResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedEvaluationResource")]
        [Validation(Required=false)]
        public string SupportedEvaluationResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedInferenceResource")]
        [Validation(Required=false)]
        public string SupportedInferenceResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GP7V</para>
        /// </summary>
        [NameInMap("SupportedTrainingResource")]
        [Validation(Required=false)]
        public string SupportedTrainingResource { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListModelGalleryModelsRequestTag> Tag { get; set; }
        public class ListModelGalleryModelsRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>large-language-model</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Trainable")]
        [Validation(Required=false)]
        public bool? Trainable { get; set; }

    }

}
