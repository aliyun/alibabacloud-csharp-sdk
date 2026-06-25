// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the connection, specified as key-value pairs. The keys in the Configs parameter vary based on the connection type. For more information, see the request parameters in the CreateConnection topic.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The description of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Connection for data labeling.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of model information.</para>
        /// </summary>
        [NameInMap("Models")]
        [Validation(Required=false)]
        public List<UpdateConnectionRequestModels> Models { get; set; }
        public class UpdateConnectionRequestModels : TeaModel {
            /// <summary>
            /// <para>The display name of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>car_tag</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The model identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model_001</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>LLM</para>
            /// </description></item>
            /// <item><description><para>Embedding</para>
            /// </description></item>
            /// <item><description><para>ReRank</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Indicates whether tool calling is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Tool calling is supported.</para>
            /// </description></item>
            /// <item><description><para>false: Tool calling is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ToolCall")]
            [Validation(Required=false)]
            public bool? ToolCall { get; set; }

        }

        /// <summary>
        /// <para>Key-value pairs that require encryption, such as database logon passwords and keys for model connections.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

    }

}
