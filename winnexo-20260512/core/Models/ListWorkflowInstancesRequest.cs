// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkflowInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The exact requirement ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-1001</para>
        /// </summary>
        [NameInMap("businessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// <para>The collaboration space ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_20261016_abc123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The exact external initiator tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>External initiator Zhang San</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        /// <summary>
        /// <para>The keyword for the title or requirement ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly report</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GMT_CREATE</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("sortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>Filters the instances by status. Valid values: Running, Completed, Failed, and Terminated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If you use winnexo-cli, pass this parameter explicitly by using --tenant-id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
