// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDelayConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The duration for which the playback of the live stream is delayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public string DelayTime { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
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
        /// <para>The name of the live stream.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

        /// <summary>
        /// <para>The trigger mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PUBLISH_ONLY</b>: Stream delay can be triggered only by specifying the stream delay parameter in the ingest URL.</description></item>
        /// <item><description><b>CONFIG_ONLY</b>: Stream delay can be triggered only by the stream delay configuration.</description></item>
        /// <item><description><b>PUBLISH_CONFIG</b>: Stream delay can be triggered by the stream delay parameter in the ingest URL or the stream delay configuration. The stream delay parameter takes precedence over the stream delay configuration.</description></item>
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
