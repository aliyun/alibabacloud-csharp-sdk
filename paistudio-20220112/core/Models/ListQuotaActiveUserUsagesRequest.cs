// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListQuotaActiveUserUsagesRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>999</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to view only the resource usage in the current quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SelfOnly")]
        [Validation(Required=false)]
        public bool? SelfOnly { get; set; }

        /// <summary>
        /// <para>The field by which to sort the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>QuotaId</description></item>
        /// <item><description>SubmittedCPU</description></item>
        /// <item><description>SubmittedMemory</description></item>
        /// <item><description>SubmittedGPU</description></item>
        /// <item><description>UsedCPU</description></item>
        /// <item><description>UsedMemory</description></item>
        /// <item><description>UsedGPU</description></item>
        /// <item><description>WorkloadCount</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The user ID for which to query resource usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200xxxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username for which to query resource usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("WorkloadCount")]
        [Validation(Required=false)]
        public int? WorkloadCount { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
