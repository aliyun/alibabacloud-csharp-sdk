// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBBranchRestoreWindowResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the source branch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <para>DBClusterId</para>
        /// 
        /// <b>Example:</b>
        /// <para>pagc-bp1abcdef1234567</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The earliest time available for creating a historical branch, in UTC RFC3339 format. This time point can be selected. The available range changes over time and is revalidated during creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T07:32:00Z</para>
        /// </summary>
        [NameInMap("EarliestRestorableTime")]
        [Validation(Required=false)]
        public string EarliestRestorableTime { get; set; }

        /// <summary>
        /// <para>ProjectId</para>
        /// 
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The time when the query was completed, in UTC RFC3339 format. This does not represent the latest restorable time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16T07:32:00Z</para>
        /// </summary>
        [NameInMap("QueriedAt")]
        [Validation(Required=false)]
        public string QueriedAt { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>TenantId</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
