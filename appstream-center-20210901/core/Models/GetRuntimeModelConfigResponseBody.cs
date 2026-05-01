// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeModelConfigResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRuntimeModelConfigResponseBodyData Data { get; set; }
        public class GetRuntimeModelConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>bailian/qwen3.6-plus</para>
            /// </summary>
            [NameInMap("DefaultModel")]
            [Validation(Required=false)]
            public string DefaultModel { get; set; }

            [NameInMap("ModelProviderList")]
            [Validation(Required=false)]
            public List<GetRuntimeModelConfigResponseBodyDataModelProviderList> ModelProviderList { get; set; }
            public class GetRuntimeModelConfigResponseBodyDataModelProviderList : TeaModel {
                [NameInMap("LlmInfoList")]
                [Validation(Required=false)]
                public List<GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoList> LlmInfoList { get; set; }
                public class GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoList : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Features")]
                    [Validation(Required=false)]
                    public List<string> Features { get; set; }

                    [NameInMap("InferenceMetadata")]
                    [Validation(Required=false)]
                    public GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListInferenceMetadata InferenceMetadata { get; set; }
                    public class GetRuntimeModelConfigResponseBodyDataModelProviderListLlmInfoListInferenceMetadata : TeaModel {
                        [NameInMap("RequestModality")]
                        [Validation(Required=false)]
                        public List<string> RequestModality { get; set; }

                        [NameInMap("ResponseModality")]
                        [Validation(Required=false)]
                        public List<string> ResponseModality { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen3.6-plus</para>
                    /// </summary>
                    [NameInMap("LlmCode")]
                    [Validation(Required=false)]
                    public string LlmCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Qwen3.6-Plus</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-03-04T06:25:17.000+00:00</para>
                    /// </summary>
                    [NameInMap("PublishedTime")]
                    [Validation(Required=false)]
                    public string PublishedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("RiskType")]
                    [Validation(Required=false)]
                    public string RiskType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mpt-xxxx</para>
                /// </summary>
                [NameInMap("ModelProviderTemplateId")]
                [Validation(Required=false)]
                public string ModelProviderTemplateId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bailian</para>
                /// </summary>
                [NameInMap("ProviderName")]
                [Validation(Required=false)]
                public string ProviderName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model-template-001</para>
            /// </summary>
            [NameInMap("ModelTemplateName")]
            [Validation(Required=false)]
            public string ModelTemplateName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
