// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListScheduledTasksRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collaboration group (such as cg_101). If specified, a group task is created (the caller must be a valid group member). If left empty, a personal task is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleCollaborationGroupId</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only tasks created by the caller. This parameter takes effect only in the group dimension (in the personal dimension, only the caller\&quot;s own tasks are returned). If not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("creatorOnly")]
        [Validation(Required=false)]
        public bool? CreatorOnly { get; set; }

        /// <summary>
        /// <para>The keyword of the rule name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleKeyword</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eHiB8vca1XDyBT0cNAmThA==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para>The maximum number of entries per page is 30.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The tenant ID that takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>Filters by visibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE: visible only to the creator and group owner.</description></item>
        /// <item><description>COLLABORATIVE: visible to specified collaborators.</description></item>
        /// <item><description>PUBLIC: visible to all group members.</description></item>
        /// </list>
        /// <para>If not specified or an empty list is passed, no filtering is applied. This parameter takes effect only in the group dimension (when collaborationGroupId is specified) and is ignored in the personal dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibilities")]
        [Validation(Required=false)]
        public List<string> Visibilities { get; set; }

    }

}
