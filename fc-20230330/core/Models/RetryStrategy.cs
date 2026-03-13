// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RetryStrategy : TeaModel {
        /// <summary>
        /// <para>The retry policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BACKOFF_RETRY</b>: retries with a fixed backoff interval.</description></item>
        /// <item><description><b>EXPONENTIAL_DECAY_RETRY</b>: retries with exponential backoff.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("PushRetryStrategy")]
        [Validation(Required=false)]
        public string PushRetryStrategy { get; set; }

    }

}
