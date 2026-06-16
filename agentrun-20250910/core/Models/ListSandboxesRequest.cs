// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListSandboxesRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next set of results. A non-empty value indicates that more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dnLkmeaJc9vHgbzREh2l0J4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01KMB33KCB3YRYE9C2AJCW5DQK</para>
        /// </summary>
        [NameInMap("sandboxId")]
        [Validation(Required=false)]
        public string SandboxId { get; set; }

        /// <summary>
        /// <para>Filters the results by status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Filters the results by template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>templateName</para>
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>Filters the results by template type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TASK</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
