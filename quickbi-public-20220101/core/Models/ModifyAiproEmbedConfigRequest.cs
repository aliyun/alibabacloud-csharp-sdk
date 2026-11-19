// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ModifyAiproEmbedConfigRequest : TeaModel {
        /// <summary>
        /// <para>The nickname of the agent. The default value is Intelligent Data Analytics Assistant when you create a configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The AIPro configuration ID. If this parameter is not specified or is left empty, a new configuration is created. If this parameter is specified, the existing configuration is updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AiProId")]
        [Validation(Required=false)]
        public string AiProId { get; set; }

        /// <summary>
        /// <para>Specifies whether to display the chat history. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Display.</description></item>
        /// <item><description>0: Do not display.</description></item>
        /// </list>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChatHistoryStatus")]
        [Validation(Required=false)]
        public int? ChatHistoryStatus { get; set; }

        /// <summary>
        /// <para>The JSON string of the embedding appearance configuration saved on the frontend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable memory. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Enable.</description></item>
        /// <item><description>0: Disable.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MemoryEnabled")]
        [Validation(Required=false)]
        public int? MemoryEnabled { get; set; }

        /// <summary>
        /// <para>The name of the configuration. This parameter is required and must be unique within the organization when you create a configuration. If this parameter is left empty when you update a configuration, the name is not updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ShowName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow file uploads. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Allow.</description></item>
        /// <item><description>0: Do not allow.</description></item>
        /// </list>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UploadEnabled")]
        [Validation(Required=false)]
        public int? UploadEnabled { get; set; }

    }

}
