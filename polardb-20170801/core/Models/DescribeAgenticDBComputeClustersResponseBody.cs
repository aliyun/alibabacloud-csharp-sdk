// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBComputeClustersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of compute instances.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAgenticDBComputeClustersResponseBodyItems> Items { get; set; }
        public class DescribeAgenticDBComputeClustersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The associated branch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-7g8h9i0j1k2l</para>
            /// </summary>
            [NameInMap("BranchId")]
            [Validation(Required=false)]
            public string BranchId { get; set; }

            /// <summary>
            /// <para>The associated branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature-analytics</para>
            /// </summary>
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            /// <summary>
            /// <para>The compute instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-g0lsayq8c5qe</para>
            /// </summary>
            [NameInMap("ComputeClusterId")]
            [Validation(Required=false)]
            public string ComputeClusterId { get; set; }

            /// <summary>
            /// <para>The number of compute nodes (fixed to 1 in the first phase).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComputeNodeCount")]
            [Validation(Required=false)]
            public int? ComputeNodeCount { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in ISO 8601 format and uses the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T11:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Compute cluster for analytics</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether it is the default branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultBranch")]
            [Validation(Required=false)]
            public bool? IsDefaultBranch { get; set; }

            /// <summary>
            /// <para>The last activation time.
            /// The time is in ISO 8601 format and uses the UTC time zone (format: YYYY-MM-DDTHH:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T12:30:00Z</para>
            /// </summary>
            [NameInMap("LastActivatedAt")]
            [Validation(Required=false)]
            public string LastActivatedAt { get; set; }

            /// <summary>
            /// <para>The maximum compute unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxCU")]
            [Validation(Required=false)]
            public string MaxCU { get; set; }

            /// <summary>
            /// <para>The minimum compute unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("MinCU")]
            [Validation(Required=false)]
            public string MinCU { get; set; }

            /// <summary>
            /// <para>The operator type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Neon</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <para>The parent branch ID. An empty string indicates the root branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-1a2b3c4d5e6f</para>
            /// </summary>
            [NameInMap("ParentBranchId")]
            [Validation(Required=false)]
            public string ParentBranchId { get; set; }

            /// <summary>
            /// <para>The parent branch name. An empty string indicates the root branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("ParentBranchName")]
            [Validation(Required=false)]
            public string ParentBranchName { get; set; }

            /// <summary>
            /// <para>The associated project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proj-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The associated project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>analytics-prod</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The used data volume (in bytes).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public long? StorageSize { get; set; }

            /// <summary>
            /// <para>The associated tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-4b83e0da66674951</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The associated tenant name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-saas-app</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6A7B8C9-D0E1-2345-FABC-678901234FAB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
