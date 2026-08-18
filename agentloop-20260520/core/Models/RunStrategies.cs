// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class RunStrategies : TeaModel {
        /// <summary>
        /// <para>The historical batch backfill policy. Backfill is enabled when the object exists and enabled is not explicitly set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:true,&quot;startTime&quot;:1782816000000,&quot;endTime&quot;:1782902400000,&quot;immediate&quot;:false}</para>
        /// </summary>
        [NameInMap("backfill")]
        [Validation(Required=false)]
        public BackfillStrategy Backfill { get; set; }

        /// <summary>
        /// <para>The continuous evaluation policy. Continuous evaluation is enabled when the object exists and enabled is not explicitly set to false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enabled&quot;:true,&quot;intervalUnit&quot;:&quot;HOUR&quot;,&quot;intervalValue&quot;:1,&quot;dataDelayMinutes&quot;:5}</para>
        /// </summary>
        [NameInMap("continuous")]
        [Validation(Required=false)]
        public ContinuousStrategy Continuous { get; set; }

    }

}
