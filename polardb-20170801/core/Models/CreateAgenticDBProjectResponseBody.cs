// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateAgenticDBProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the compute instance bound to the default branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-g0lsayq8c5qe</para>
        /// </summary>
        [NameInMap("BranchComputeClusterId")]
        [Validation(Required=false)]
        public string BranchComputeClusterId { get; set; }

        /// <summary>
        /// <para>The time when the project was created. The time is displayed in ISO 8601 format in UTC (YYYY-MM-DDTHH:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-10T11:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the default branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("DefaultBranchId")]
        [Validation(Required=false)]
        public string DefaultBranchId { get; set; }

        /// <summary>
        /// <para>The name of the default branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("DefaultBranchName")]
        [Validation(Required=false)]
        public string DefaultBranchName { get; set; }

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
        /// <para>The ID of the new project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
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
        /// <para>E5F6A7B8-C9D0-1234-EFAB-345678901234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
