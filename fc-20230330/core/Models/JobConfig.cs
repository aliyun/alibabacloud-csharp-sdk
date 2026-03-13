// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class JobConfig : TeaModel {
        /// <summary>
        /// <para>The maximum number of retries. Valid values: 0 to 100. This parameter specifies the maximum number of retries allowed when Simple Log Service triggers a function based on the trigger interval if an error occurs, such as insufficient permissions, network failures, and function execution exceptions. If the trigger fails after the maximum number of retries is reached, Simple Log Service triggers the function again when the next trigger interval arrives.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("maxRetryTime")]
        [Validation(Required=false)]
        public int? MaxRetryTime { get; set; }

        /// <summary>
        /// <para>The time interval at which Simple Log Service triggers function execution. For example, you can retrieve data from the Logstore within the last 120 seconds to Function Compute every 120 seconds to perform custom computing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("triggerInterval")]
        [Validation(Required=false)]
        public int? TriggerInterval { get; set; }

    }

}
