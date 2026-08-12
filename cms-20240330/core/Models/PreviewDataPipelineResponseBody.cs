// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PreviewDataPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The dataset preview results.</para>
        /// </summary>
        [NameInMap("datasets")]
        [Validation(Required=false)]
        public List<PreviewDataPipelineResponseBodyDatasets> Datasets { get; set; }
        public class PreviewDataPipelineResponseBodyDatasets : TeaModel {
            /// <summary>
            /// <para>The preview data.</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Data { get; set; }

            /// <summary>
            /// <para>The field metadata.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<PreviewDataPipelineResponseBodyDatasetsMeta> Meta { get; set; }
            public class PreviewDataPipelineResponseBodyDatasetsMeta : TeaModel {
                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trace_id</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The dataset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error_spans</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of samples.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sampleCount")]
            [Validation(Required=false)]
            public long? SampleCount { get; set; }

        }

        /// <summary>
        /// <para>The effective SPL.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| where status_code == &quot;ERROR&quot;</description></item>
        /// </list>
        /// </summary>
        [NameInMap("effectiveScript")]
        [Validation(Required=false)]
        public string EffectiveScript { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-01j2example</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
