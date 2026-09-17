// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ExperimentConfig : TeaModel {
        /// <summary>
        /// <para>The endpoint connector ID. This parameter is required in user/agent mode.</para>
        /// </summary>
        [NameInMap("endpointConnectorId")]
        [Validation(Required=false)]
        public string EndpointConnectorId { get; set; }

        /// <summary>
        /// <para>The experiment label (A/B/C/D/E).</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The model name. You can set this parameter to agent in agent scenarios.</para>
        /// </summary>
        [NameInMap("modelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model parameters.</para>
        /// </summary>
        [NameInMap("modelParameters")]
        [Validation(Required=false)]
        public ModelParameters ModelParameters { get; set; }

        /// <summary>
        /// <para>The model provider. Valid values: dashscope (default), user, and agent.</para>
        /// </summary>
        [NameInMap("modelProvider")]
        [Validation(Required=false)]
        public string ModelProvider { get; set; }

        /// <summary>
        /// <para>The experiment name.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The prompt message template. Supports {{variable name}} placeholders.</para>
        /// </summary>
        [NameInMap("promptTemplate")]
        [Validation(Required=false)]
        public List<PromptTemplateItem> PromptTemplate { get; set; }

        /// <summary>
        /// <para>The agent request body template. This parameter is required in agent mode. Supports {{variable name}} placeholders.</para>
        /// </summary>
        [NameInMap("requestBodyTemplate")]
        [Validation(Required=false)]
        public string RequestBodyTemplate { get; set; }

        /// <summary>
        /// <para>The agent request header template. This parameter is optional in agent mode. Supports {{variable name}} placeholders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Content-Type: application/json&quot; }</para>
        /// </summary>
        [NameInMap("requestHeaderTemplate")]
        [Validation(Required=false)]
        public string RequestHeaderTemplate { get; set; }

        /// <summary>
        /// <para>The agent request method. Valid values: POST (default) and GET.</para>
        /// </summary>
        [NameInMap("requestMethod")]
        [Validation(Required=false)]
        public string RequestMethod { get; set; }

    }

}
