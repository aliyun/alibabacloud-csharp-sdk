// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class CreatePromptRequest : TeaModel {
        /// <summary>
        /// <para>Business tags, comma-separated</para>
        /// 
        /// <b>Example:</b>
        /// <para>cs,qa,support</para>
        /// </summary>
        [NameInMap("BizTags")]
        [Validation(Required=false)]
        public string BizTags { get; set; }

        /// <summary>
        /// <para>Commit message</para>
        /// 
        /// <b>Example:</b>
        /// <para>初始版本</para>
        /// </summary>
        [NameInMap("CommitMsg")]
        [Validation(Required=false)]
        public string CommitMsg { get; set; }

        /// <summary>
        /// <para>Prompt description</para>
        /// 
        /// <b>Example:</b>
        /// <para>客服问答 Prompt</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>Prompt unique identifier</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customer-service-qa</para>
        /// </summary>
        [NameInMap("PromptKey")]
        [Validation(Required=false)]
        public string PromptKey { get; set; }

        /// <summary>
        /// <para>Version number for the initial draft version of the prompt. Defaults to 0.0.1 if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// <para>Template content for the initial draft version of the prompt</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你是一个客服助手，请回答：{question}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>Variable definitions, JSON array string, supporting name, description, and defaultValue parameters</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;question&quot;,&quot;defaultValue&quot;:&quot;Hello&quot;}]</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
