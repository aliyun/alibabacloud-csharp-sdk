// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class CreateGeneralConfigRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the configuration item. Supported keys include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>MiaoSou text search threshold (double): searchGenerate.searchTextMinScore</para>
        /// </description></item>
        /// <item><description><para>MiaoSou image search threshold (double): searchGenerate.searchImageMinScore</para>
        /// </description></item>
        /// <item><description><para>MiaoSou video search threshold (double): searchGenerate.searchVideoMinScore</para>
        /// </description></item>
        /// <item><description><para>MiaoSou audio search threshold (double): searchGenerate.searchAudioMinScore</para>
        /// </description></item>
        /// <item><description><para>MiaoSou Q\&amp;A search general answer summary prompt template (string): searchGenerate.sumQaAgentPrompt</para>
        /// </description></item>
        /// <item><description><para>MiaoSou Q\&amp;A search general answer summary prompt template with text and images (string): searchGenerate.sumQaAgentVlPrompt</para>
        /// </description></item>
        /// <item><description><para>MiaoSou Q\&amp;A search deep answer summary prompt template (string): searchGenerate.sumQaEnhanceAgentPrompt</para>
        /// </description></item>
        /// <item><description><para>MiaoSou Q\&amp;A search deep answer summary prompt template with text and images (string): searchGenerate.sumQaEnhanceAgentVlPrompt</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>Value of the configuration item</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>Unique identifier of the Model Studio workspace. <a href="https://help.aliyun.com/document_detail/2782167.html">Get the workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
