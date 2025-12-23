// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListQuotaReviewTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;3351A21F-705B-508C-9450-DA65A681547F&quot;</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the tickets. For more information, see <a href="https://help.aliyun.com/document_detail/173609.html">QuotaReviewTask</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListQuotaReviewTasksResponseBodyResult> Result { get; set; }
        public class ListQuotaReviewTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120123456</para>
            /// </summary>
            [NameInMap("appGroupId")]
            [Validation(Required=false)]
            public int? AppGroupId { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;td_test_os&quot;</para>
            /// </summary>
            [NameInMap("appGroupName")]
            [Validation(Required=false)]
            public string AppGroupName { get; set; }

            /// <summary>
            /// <para>The application type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;standard&quot;</para>
            /// </summary>
            [NameInMap("appGroupType")]
            [Validation(Required=false)]
            public string AppGroupType { get; set; }

            /// <summary>
            /// <para>Indicates whether the ticket is approved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("approved")]
            [Validation(Required=false)]
            public bool? Approved { get; set; }

            /// <summary>
            /// <para>Indicates whether the application is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("available")]
            [Validation(Required=false)]
            public bool? Available { get; set; }

            /// <summary>
            /// <para>The time when the ticket was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;2020-04-08T08:29:45+0000&quot;</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the ticket was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;2020-04-08T08:36:36+0000&quot;</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>142</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <para>The computing resource quota that is applied for.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("newComputeResource")]
            [Validation(Required=false)]
            public int? NewComputeResource { get; set; }

            /// <summary>
            /// <para>The storage capacity quota that is applied for.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100</para>
            /// </summary>
            [NameInMap("newSocSize")]
            [Validation(Required=false)]
            public int? NewSocSize { get; set; }

            /// <summary>
            /// <para>The application specifications that are applied for.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;opensearch.private.common&quot;</para>
            /// </summary>
            [NameInMap("newSpec")]
            [Validation(Required=false)]
            public string NewSpec { get; set; }

            /// <summary>
            /// <para>The original quota of computing resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("oldComputeResource")]
            [Validation(Required=false)]
            public int? OldComputeResource { get; set; }

            /// <summary>
            /// <para>The original quota of storage capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>900</para>
            /// </summary>
            [NameInMap("oldDocSize")]
            [Validation(Required=false)]
            public int? OldDocSize { get; set; }

            /// <summary>
            /// <para>The original specifications of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;opensearch.private.common&quot;</para>
            /// </summary>
            [NameInMap("oldSpec")]
            [Validation(Required=false)]
            public string OldSpec { get; set; }

            /// <summary>
            /// <para>Indicates whether the ticket is pending.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("pending")]
            [Validation(Required=false)]
            public bool? Pending { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
