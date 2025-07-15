// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveDelayConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can specify an asterisk (\*) as the value to match all applications that belong to the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The duration for which the playback of the live stream is delayed. The value must be an integer. Valid values: 16 to 3600. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("DelayTime")]
        [Validation(Required=false)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can use the wildcard (\*) to specify all streams of the application.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLISH_ONLY</para>
        /// </summary>
        [NameInMap("TaskTriggerMode")]
        [Validation(Required=false)]
        public string TaskTriggerMode { get; set; }

    }

}
