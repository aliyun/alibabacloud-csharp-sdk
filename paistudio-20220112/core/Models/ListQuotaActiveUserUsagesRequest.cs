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
        /// <item><description><para><c>desc</c>: descending order.</para>
        /// </description></item>
        /// <item><description><para><c>asc</c>: ascending order.</para>
        /// </description></item>
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
        /// <para>If true, retrieves resource usage from the current quota only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SelfOnly")]
        [Validation(Required=false)]
        public bool? SelfOnly { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>QuotaId</para>
        /// </description></item>
        /// <item><description><para>SubmittedCPU</para>
        /// </description></item>
        /// <item><description><para>SubmittedMemory</para>
        /// </description></item>
        /// <item><description><para>SubmittedGPU</para>
        /// </description></item>
        /// <item><description><para>UsedCPU</para>
        /// </description></item>
        /// <item><description><para>UsedMemory</para>
        /// </description></item>
        /// <item><description><para>UsedGPU</para>
        /// </description></item>
        /// <item><description><para>WorkloadCount</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Filters the results by user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200xxxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>Filters the results by username.</para>
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
