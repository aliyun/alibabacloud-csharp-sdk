// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class QueryWorkItemFeedRequest : TeaModel {
        /// <summary>
        /// <para>The business status filter (seven states).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("businessStatuses")]
        [Validation(Required=false)]
        public List<string> BusinessStatuses { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The pagination cursor. Use the nextCursor value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// <para>The work item type filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("itemTypes")]
        [Validation(Required=false)]
        public List<string> ItemTypes { get; set; }

        /// <summary>
        /// <para>The keyword for fuzzy search in the title or description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The priority filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("priorities")]
        [Validation(Required=false)]
        public List<string> Priorities { get; set; }

        /// <summary>
        /// <para>The personal scope filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSIGNED_TO_ME</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The ID of the source task. If specified, the flat sub-items of the task are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceTaskId")]
        [Validation(Required=false)]
        public string SourceTaskId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The view type. Valid values: FLAT (flat view) and TREE (task grouping).</para>
        /// 
        /// <b>Example:</b>
        /// <para>FLAT</para>
        /// </summary>
        [NameInMap("view")]
        [Validation(Required=false)]
        public string View { get; set; }

    }

}
