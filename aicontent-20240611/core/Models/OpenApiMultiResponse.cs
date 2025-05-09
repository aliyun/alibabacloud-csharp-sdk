// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class OpenApiMultiResponse : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<OpenApiMultiResponseData> Data { get; set; }
        public class OpenApiMultiResponseData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>456</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public List<string> ImageUrl { get; set; }

            [NameInMap("inferenceImageCount")]
            [Validation(Required=false)]
            public int? InferenceImageCount { get; set; }

            [NameInMap("inferenceJobList")]
            [Validation(Required=false)]
            public List<OpenApiMultiResponseDataInferenceJobList> InferenceJobList { get; set; }
            public class OpenApiMultiResponseDataInferenceJobList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-12-25T12:00:00</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3220</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>FINISHED</para>
                /// </summary>
                [NameInMap("jobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("jobTrainProgress")]
                [Validation(Required=false)]
                public double? JobTrainProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>modelId-xxxx-xxxx-xxxx</para>
                /// </summary>
                [NameInMap("modelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>promptId-xxxx-xxxx-xxxx</para>
                /// </summary>
                [NameInMap("promptId")]
                [Validation(Required=false)]
                public string PromptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0000.png</para>
                /// </summary>
                [NameInMap("resultImageUrl")]
                [Validation(Required=false)]
                public List<string> ResultImageUrl { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TRAINING</para>
            /// </summary>
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("jobTrainProgress")]
            [Validation(Required=false)]
            public double? JobTrainProgress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>modelId-xxxx-xxxx-xxxx</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>可爱熊猫模型训练任务</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>panda</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
