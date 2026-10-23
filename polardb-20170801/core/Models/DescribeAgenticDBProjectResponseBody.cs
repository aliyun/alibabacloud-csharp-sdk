// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// <para>The time is displayed in ISO 8601 format in the UTC time zone (YYYY-MM-DDTHH:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-10T11:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The default branch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("DefaultBranchId")]
        [Validation(Required=false)]
        public string DefaultBranchId { get; set; }

        /// <summary>
        /// <para>The default branch name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("DefaultBranchName")]
        [Validation(Required=false)]
        public string DefaultBranchName { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Production analytics database</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The retention period for recent records of the project. This parameter may be empty for older projects. To query the current effective value, call DescribeAgenticDBProjectHistoryRetention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>604800</para>
        /// </summary>
        [NameInMap("HistoryRetentionSeconds")]
        [Validation(Required=false)]
        public long? HistoryRetentionSeconds { get; set; }

        /// <summary>
        /// <para>Project ID</para>
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
        /// <para>I9J0K1L2-M3N4-5678-IJKL-789012345678</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The project status. Valid values: Active (Normal), Destroying (Destroying), and Destroyed (Destroyed).</para>
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
