// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class SelectedDataStrategy : TeaModel {
        /// <summary>
        /// <para>The end time of the statistical window in UNIX seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735660800</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The list of evaluation IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;2646a9380bba3c86371f55a0226322941794983634&quot;]</para>
        /// </summary>
        [NameInMap("evalIds")]
        [Validation(Required=false)]
        public List<string> EvalIds { get; set; }

        /// <summary>
        /// <para>The estimated start time in milliseconds.</para>
        /// <remarks>
        /// <para>You can modify this parameter only when the course is in the preview state.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1735574400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
