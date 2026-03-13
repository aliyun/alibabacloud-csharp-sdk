// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceConfig : TeaModel {
        /// <summary>
        /// <para>The name of the Logstore. The trigger periodically subscribes to data from this Logstore and then triggers the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-logstore-name</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The start time of consumption. Unit: seconds. If you do not specify this parameter, consumption starts from the latest data. If this parameter is specified, a trigger event is generated for data written after the specified time. For consumption of existing data, the trigger interval is ignored to catch up with the consumption delay until the real-time trigger progress is caught up. When the catch-up is complete, the trigger starts to trigger function invocations based on the specified trigger event interval without delay.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1704790317</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
