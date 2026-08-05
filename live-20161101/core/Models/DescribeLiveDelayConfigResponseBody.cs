// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDelayConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The playback latency of the stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public string DelayTime { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stream name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        /// <summary>
        /// <para>The trigger mode for the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLISH_ONLY</b>: The task is triggered only when stream ingest parameters for delayed playback are specified.</description></item>
        /// <item><description><b>CONFIG_ONLY</b>: The task is triggered only by the configuration. Stream ingest parameters are ignored.</description></item>
        /// <item><description><b>PUBLISH_CONFIG</b>: The task can be triggered by both stream ingest parameters and the configuration. Stream ingest parameters have a higher priority than the configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISH_ONLY</para>
        /// </summary>
        [NameInMap("TaskTriggerMode")]
        [Validation(Required=false)]
        public string TaskTriggerMode { get; set; }

    }

}
