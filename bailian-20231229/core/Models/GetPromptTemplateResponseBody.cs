// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetPromptTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The template content.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6e49109bfeb94a39bb268f4e483ccxxx</para>
        /// </summary>
        [NameInMap("promptTemplateId")]
        [Validation(Required=false)]
        public string PromptTemplateId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C56C7AF-6573-19CE-B018-E05E1EDCF4C5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The variables of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;theme&quot;]</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<string> Variables { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-us9hjmt32nysdxxx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
