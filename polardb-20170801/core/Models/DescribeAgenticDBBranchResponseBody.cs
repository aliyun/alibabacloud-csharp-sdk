// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBBranchResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the compute cluster for the branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-g0lsayq8c5qe</para>
        /// </summary>
        [NameInMap("BranchComputeClusterId")]
        [Validation(Required=false)]
        public string BranchComputeClusterId { get; set; }

        /// <summary>
        /// <para>The number of compute nodes. The value is fixed to 1 in the first phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BranchComputeNodeCount")]
        [Validation(Required=false)]
        public int? BranchComputeNodeCount { get; set; }

        /// <summary>
        /// <para>The branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-7g8h9i0j1k2l</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>The name of the branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>feature-analytics</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <para>The creation time. The time follows the ISO 8601 standard in the UTC time zone. Format: YYYY-MM-DDTHH:mm:ssZ.</para>
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
        /// <para>Feature branch for analytics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the branch is the default branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultBranch")]
        [Validation(Required=false)]
        public bool? IsDefaultBranch { get; set; }

        /// <summary>
        /// <para>The time when the branch was last activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-10T12:30:00Z</para>
        /// </summary>
        [NameInMap("LastActivatedAt")]
        [Validation(Required=false)]
        public string LastActivatedAt { get; set; }

        /// <summary>
        /// <para>The maximum number of compute units (CUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxCU")]
        [Validation(Required=false)]
        public string MaxCU { get; set; }

        /// <summary>
        /// <para>The minimum number of compute units (CUs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.25</para>
        /// </summary>
        [NameInMap("MinCU")]
        [Validation(Required=false)]
        public string MinCU { get; set; }

        /// <summary>
        /// <para>The ID of the parent branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("ParentBranchId")]
        [Validation(Required=false)]
        public string ParentBranchId { get; set; }

        /// <summary>
        /// <para>The name of the parent branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("ParentBranchName")]
        [Validation(Required=false)]
        public string ParentBranchName { get; set; }

        /// <summary>
        /// <para>The historical time of the parent branch specified when the branch is created. The time follows the RFC 3339 standard in the UTC time zone. If no historical time is specified or for old records, this value may be empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T07:32:00.123456Z</para>
        /// </summary>
        [NameInMap("ParentTimestamp")]
        [Validation(Required=false)]
        public string ParentTimestamp { get; set; }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the project to which the branch belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics-prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3D4E5F6-A7B8-9012-CDEF-345678901CDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the branch. Valid values: Running, Pending, and Paused.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
