// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ModelSetSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("apiInvokeType")]
        [Validation(Required=false)]
        public string ApiInvokeType { get; set; }

        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public Authorization AuthConfig { get; set; }

        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        [NameInMap("features")]
        [Validation(Required=false)]
        public ModelSetSpecFeatures Features { get; set; }
        public class ModelSetSpecFeatures : TeaModel {
            [NameInMap("agentThought")]
            [Validation(Required=false)]
            public bool? AgentThought { get; set; }

            [NameInMap("toolCall")]
            [Validation(Required=false)]
            public bool? ToolCall { get; set; }

            [NameInMap("vision")]
            [Validation(Required=false)]
            public bool? Vision { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<ModelSetModelProfile> Models { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FunctionAI</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
