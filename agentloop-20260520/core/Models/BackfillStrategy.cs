// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class BackfillStrategy : TeaModel {
        /// <summary>
        /// <para>Specifies whether the backfill policy is enabled. If this parameter is not specified or is set to true, the policy is enabled. If this parameter is set to false, the policy is disabled but the configuration is retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The end of the backfill time range, in UNIX millisecond timestamp. Provide a complete time range when you need to manually start a backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782902400000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the backfill time range, in UNIX millisecond timestamp. Provide a complete time range when you need to manually start a backfill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1782816000000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
