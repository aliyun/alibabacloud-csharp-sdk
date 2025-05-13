// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListWorkspacesShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-heyuan</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test-001</para>
        /// </summary>
        [NameInMap("workspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test-001</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("workspaceNameList")]
        [Validation(Required=false)]
        public string WorkspaceNameListShrink { get; set; }

    }

}
