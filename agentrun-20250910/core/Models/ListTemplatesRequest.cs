// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the template. Use this parameter to filter templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The name of the template. Use this parameter to filter templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temp-abc</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The type of the template. Use this parameter to filter templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Browser</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the template belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The IDs of the workspaces. You can use this parameter to query templates from multiple workspaces.</para>
        /// </summary>
        [NameInMap("workspaceIds")]
        [Validation(Required=false)]
        public string WorkspaceIds { get; set; }

    }

}
