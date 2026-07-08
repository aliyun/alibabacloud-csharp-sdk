// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunTranslateGenerationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The target language for translation. The source language is automatically detected.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Language</th>
        /// <th>Prompt value</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>English</td>
        /// <td>English</td>
        /// </tr>
        /// <tr>
        /// <td>Simplified Chinese</td>
        /// <td>Chinese</td>
        /// </tr>
        /// <tr>
        /// <td>Japanese</td>
        /// <td>Japanese</td>
        /// </tr>
        /// <tr>
        /// <td>Korean</td>
        /// <td>Korean</td>
        /// </tr>
        /// <tr>
        /// <td>Spanish</td>
        /// <td>Spanish</td>
        /// </tr>
        /// <tr>
        /// <td>French</td>
        /// <td>French</td>
        /// </tr>
        /// <tr>
        /// <td>Portuguese</td>
        /// <td>Portuguese</td>
        /// </tr>
        /// <tr>
        /// <td>German</td>
        /// <td>German</td>
        /// </tr>
        /// <tr>
        /// <td>Italian</td>
        /// <td>Italian</td>
        /// </tr>
        /// </tbody></table>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>English</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The data required for generation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ReferenceData")]
        [Validation(Required=false)]
        public string ReferenceDataShrink { get; set; }

        /// <summary>
        /// <para>Optional. The unique ID of the associated creative article.</para>
        /// <remarks>
        /// <para>You do not need to specify TaskId. The system generates one automatically. If subsequent tasks use the same TaskId, they belong to the same conversation group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The unique ID of the Alibaba Cloud Model Studio workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2782167.html">Get a Workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
