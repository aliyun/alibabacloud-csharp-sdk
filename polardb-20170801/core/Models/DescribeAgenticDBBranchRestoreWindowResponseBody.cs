// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBBranchRestoreWindowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>br-1a2b3c4d5e6f</para>
        /// </summary>
        [NameInMap("BranchId")]
        [Validation(Required=false)]
        public string BranchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pagc-bp1abcdef1234567</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>可用于创建历史分支的最早时间，采用 UTC RFC3339 格式，允许选择该时间点。范围会随时间变化，创建时会再次校验。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-15T07:32:00Z</para>
        /// </summary>
        [NameInMap("EarliestRestorableTime")]
        [Validation(Required=false)]
        public string EarliestRestorableTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>proj-a1b2c3d4e5f6</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>完成本次查询的时间，采用 UTC RFC3339 格式，不代表最晚可恢复时间。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16T07:32:00Z</para>
        /// </summary>
        [NameInMap("QueriedAt")]
        [Validation(Required=false)]
        public string QueriedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>req-123</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-4b83e0da66674951</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
