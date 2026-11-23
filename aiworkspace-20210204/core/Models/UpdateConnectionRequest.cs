// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdateConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information of the connection. The configurations are in key-value pairs. The keys in the Config parameter vary based on the connection type. For more information, see the supplementary description of the request parameters for the CreateConnection operation.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Configs { get; set; }

        /// <summary>
        /// <para>The description of the connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Connection used for annotation</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of model information.</para>
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
            /// <item><description>LLM</description></item>
            /// <item><description>Embedding</description></item>
            /// <item><description>ReRank</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>LLM</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            /// <summary>
            /// <para>Specifies whether tool calling is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Supported.</description></item>
            /// <item><description>false: Not supported.</description></item>
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
        /// <para>The key-value configurations that need to be encrypted, such as the database logon password and the key for the model connection.</para>
        /// </summary>
        [NameInMap("Secrets")]
        [Validation(Required=false)]
        public Dictionary<string, string> Secrets { get; set; }

    }

}
