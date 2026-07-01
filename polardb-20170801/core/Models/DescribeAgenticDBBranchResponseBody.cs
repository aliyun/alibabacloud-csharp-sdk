// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBBranchResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pc-g0lsayq8c5qe</para>
        /// </summary>
        [NameInMap("BranchComputeClusterId")]
        [Validation(Required=false)]
        public string BranchComputeClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BranchComputeNodeCount")]
        [Validation(Required=false)]
        public int? BranchComputeNodeCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>br-7g8h9i0j1k2l</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>feature-analytics</para>
        /// </summary>
        [NameInMap("BranchName")]
        [Validation(Required=false)]
        public string BranchName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-10T11:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Feature branch for analytics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDefaultBranch")]
        [Validation(Required=false)]
        public bool? IsDefaultBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-10T12:30:00Z</para>
        /// </summary>
        [NameInMap("LastActivatedAt")]
        [Validation(Required=false)]
        public string LastActivatedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxCU")]
        [Validation(Required=false)]
        public string MaxCU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.25</para>
        /// </summary>
        [NameInMap("MinCU")]
        [Validation(Required=false)]
        public string MinCU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("ParentBranchId")]
        [Validation(Required=false)]
        public string ParentBranchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("ParentBranchName")]
        [Validation(Required=false)]
        public string ParentBranchName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>analytics-prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C3D4E5F6-A7B8-9012-CDEF-345678901CDE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
