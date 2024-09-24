// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupOperationResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the results of the operation.</para>
        /// </summary>
        [NameInMap("StackGroupOperationResults")]
        [Validation(Required=false)]
        public List<ListStackGroupOperationResultsResponseBodyStackGroupOperationResults> StackGroupOperationResults { get; set; }
        public class ListStackGroupOperationResultsResponseBodyStackGroupOperationResults : TeaModel {
            /// <summary>
            /// <para>The ID of the account to which the stack instance belongs.</para>
            /// <list type="bullet">
            /// <item><description>If the stack group has self-managed permissions, the stack instance belongs to an Alibaba Cloud account.</description></item>
            /// <item><description>If the stack group has service-managed permissions, the stack instance belongs to a member account in the resource directory.</description></item>
            /// </list>
            /// <remarks>
            /// <para> For more information about the account, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>175458090349****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The folder ID of the resource directory.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the stack group is granted service-managed permissions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;fd-4PvlVLOL8v&quot;</para>
            /// </summary>
            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }

            /// <summary>
            /// <para>The region ID of the stack instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the operation.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RUNNING: The operation is being performed.</description></item>
            /// <item><description>SUCCEEDED: The operation succeeded.</description></item>
            /// <item><description>FAILED: The operation failed.</description></item>
            /// <item><description>STOPPING: The operation is being stopped.</description></item>
            /// <item><description>STOPPED: The operation is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason why the operation is in a specific state.</para>
            /// <remarks>
            /// <para> This parameter is returned only when stack instances are in the OUTDATED state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>User initiated operation</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

        }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
