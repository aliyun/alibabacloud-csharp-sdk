// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UpdateGeneralConfigRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the configuration item. The following configurations are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>Text search threshold for data sources (double): \<c>searchGenerate.searchTextMinScore\\</c></para>
        /// </description></item>
        /// <item><description><para>Image search threshold for data sources (double): \<c>searchGenerate.searchImageMinScore\\</c></para>
        /// </description></item>
        /// <item><description><para>Video search threshold for data sources (double): \<c>searchGenerate.searchVideoMinScore\\</c></para>
        /// </description></item>
        /// <item><description><para>Audio search threshold for data sources (double): \<c>searchGenerate.searchAudioMinScore\\</c></para>
        /// </description></item>
        /// <item><description><para>Plain text prompt template for answer summarization in general Q\&amp;A search (string): \<c>searchGenerate.sumQaAgentPrompt\\</c></para>
        /// </description></item>
        /// <item><description><para>Text and image prompt template for answer summarization in general Q\&amp;A search (string): \<c>searchGenerate.sumQaAgentVlPrompt\\</c></para>
        /// </description></item>
        /// <item><description><para>Plain text prompt template for answer summarization in enhanced Q\&amp;A search (string): \<c>searchGenerate.sumQaEnhanceAgentPrompt\\</c></para>
        /// </description></item>
        /// <item><description><para>Text and image prompt template for answer summarization in enhanced Q\&amp;A search (string): \<c>searchGenerate.sumQaEnhanceAgentVlPrompt\\</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ConfigKey")]
        [Validation(Required=false)]
        public string ConfigKey { get; set; }

        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a workspaceId</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
