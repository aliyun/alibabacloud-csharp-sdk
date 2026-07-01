// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBBranchLineageResponseBody : TeaModel {
        /// <summary>
        /// <para>The anchor branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-7g8h9i0j1k2l</para>
        /// </summary>
        [NameInMap("AnchorBranchId")]
        [Validation(Required=false)]
        public string AnchorBranchId { get; set; }

        /// <summary>
        /// <para>The list of lineage nodes.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAgenticDBBranchLineageResponseBodyItems> Items { get; set; }
        public class DescribeAgenticDBBranchLineageResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The compute cluster ID of the branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-g0lsayq8c5qe</para>
            /// </summary>
            [NameInMap("BranchComputeClusterId")]
            [Validation(Required=false)]
            public string BranchComputeClusterId { get; set; }

            /// <summary>
            /// <para>The branch description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Feature branch for analytics</para>
            /// </summary>
            [NameInMap("BranchDescription")]
            [Validation(Required=false)]
            public string BranchDescription { get; set; }

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
            /// <para>The branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>feature-analytics</para>
            /// </summary>
            [NameInMap("BranchName")]
            [Validation(Required=false)]
            public string BranchName { get; set; }

            /// <summary>
            /// <para>The time when the branch was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T11:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The depth relative to the anchor branch. The anchor branch has a depth of 0. Ancestor branches have negative values. Descendant branches have positive values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            /// <summary>
            /// <para>The total number of direct child branches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DirectChildCount")]
            [Validation(Required=false)]
            public int? DirectChildCount { get; set; }

            /// <summary>
            /// <para>Indicates whether more ancestor nodes exist but are not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMoreAncestors")]
            [Validation(Required=false)]
            public bool? HasMoreAncestors { get; set; }

            /// <summary>
            /// <para>Indicates whether more child nodes exist but are not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMoreChildren")]
            [Validation(Required=false)]
            public bool? HasMoreChildren { get; set; }

            /// <summary>
            /// <para>Indicates whether the branch is the anchor branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAnchor")]
            [Validation(Required=false)]
            public bool? IsAnchor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultBranch")]
            [Validation(Required=false)]
            public bool? IsDefaultBranch { get; set; }

            /// <summary>
            /// <para>Indicates whether the branch is the primary branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsRoot")]
            [Validation(Required=false)]
            public bool? IsRoot { get; set; }

            /// <summary>
            /// <para>The parent branch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-1a2b3c4d5e6f</para>
            /// </summary>
            [NameInMap("ParentBranchId")]
            [Validation(Required=false)]
            public string ParentBranchId { get; set; }

            /// <summary>
            /// <para>The parent branch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("ParentBranchName")]
            [Validation(Required=false)]
            public string ParentBranchName { get; set; }

            /// <summary>
            /// <para>The branch status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active</description></item>
            /// <item><description>Destroying</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The total number of returned nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

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
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analytics-prod</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B2C3D4E5-F6A7-8901-BCDE-2345678901BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The primary branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-root</para>
        /// </summary>
        [NameInMap("RootBranchId")]
        [Validation(Required=false)]
        public string RootBranchId { get; set; }

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
