// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBProjectHistoryRetentionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pagc-bp1abcdef1234567</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>项目当前生效的历史数据保留时长。实际可恢复范围请查询分支恢复窗口。</para>
        /// 
        /// <b>Example:</b>
        /// <para>604800</para>
        /// </summary>
        [NameInMap("HistoryRetentionSeconds")]
        [Validation(Required=false)]
        public long? HistoryRetentionSeconds { get; set; }

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
