// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAgenticDBProjectHistoryRetentionResponseBody : TeaModel {
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
        /// <para>The effective history data retention period for the project. For the actual recoverable range, query the branch recovery window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>604800</para>
        /// </summary>
        [NameInMap("HistoryRetentionSeconds")]
        [Validation(Required=false)]
        public long? HistoryRetentionSeconds { get; set; }

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
        /// <para>The time when the query was completed, in UTC RFC3339 format. This does not represent the latest recoverable time.</para>
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
