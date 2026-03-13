// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MNSTopicTriggerConfig : TeaModel {
        /// <summary>
        /// <para>The filtering tag. Function execution is triggered only when a message that contains the specified filter tag is received.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverless</para>
        /// </summary>
        [NameInMap("filterTag")]
        [Validation(Required=false)]
        public string FilterTag { get; set; }

        /// <summary>
        /// <para>The format of the event content. The following two formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><b>JSON</b></description></item>
        /// <item><description><b>STREAM</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> The default format is STREAM.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("notifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// <para>The retry policy.</para>
        /// <list type="bullet">
        /// <item><description><b>BACKOFF_RETRY</b>: a backoff retry policy. A total of 3 retries are made. The interval between 2 retries is a random value between 10 and 20 seconds. This is the default value.</description></item>
        /// <item><description><b>EXPONENTIAL_DECAY_RETRY</b>: an exponential decay retry policy. A total of 176 retries are made, with the interval of each retry increases exponentially to 512 seconds, and the total retry period is 1 day. The interval between two consecutive retries exponentially increases to a maximum of 512 seconds. For example, 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 512... 512. The number of 512s is 167.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

    }

}
