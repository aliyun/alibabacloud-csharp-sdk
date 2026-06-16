// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class WindowLimit : TeaModel {
        /// <summary>
        /// <para>The duration of the time window in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public long? DurationSecs { get; set; }

        /// <summary>
        /// <para>The maximum requests allowed within the time window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

    }

}
