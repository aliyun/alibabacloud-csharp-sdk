// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ADBAI20250812.Models
{
    public class ModifyAgentPlatformRequest : TeaModel {
        [NameInMap("AiPlatformConfig")]
        [Validation(Required=false)]
        public ModifyAgentPlatformRequestAiPlatformConfig AiPlatformConfig { get; set; }
        public class ModifyAgentPlatformRequestAiPlatformConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3760d3**************************</para>
            /// </summary>
            [NameInMap("ServeApiKey")]
            [Validation(Required=false)]
            public string ServeApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://111.xx.xx.xx:8100/inferenceservice/emb">http://111.xx.xx.xx:8100/inferenceservice/emb</a></para>
            /// </summary>
            [NameInMap("ServeEmbeddingEndpoint")]
            [Validation(Required=false)]
            public string ServeEmbeddingEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen3-Embedding-8B</para>
            /// </summary>
            [NameInMap("ServeEmbeddingModelName")]
            [Validation(Required=false)]
            public string ServeEmbeddingModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://111.xx.xx.xx:8100/inferenceservice/base">http://111.xx.xx.xx:8100/inferenceservice/base</a></para>
            /// </summary>
            [NameInMap("ServeEndpoint")]
            [Validation(Required=false)]
            public string ServeEndpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen3-235B-A22B-Instruct-2507</para>
            /// </summary>
            [NameInMap("ServeModelName")]
            [Validation(Required=false)]
            public string ServeModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>large</para>
            /// </summary>
            [NameInMap("SpecName")]
            [Validation(Required=false)]
            public string SpecName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_platform</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
