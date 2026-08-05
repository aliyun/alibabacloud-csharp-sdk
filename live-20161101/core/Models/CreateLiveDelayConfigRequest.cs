// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveDelayConfigRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream. You can specify an asterisk (\*) to match all AppNames under the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The duration for which the playback is delayed. The value must be an integer. Valid values: 16 to 3600. Unit: seconds.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can use the wildcard (\*) to specify all StreamNames under the AppName.</para>
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
        /// <item><description><para><b>PUBLISH_ONLY</b>: Stream delay is triggered only by relevant parameters in the ingest URL.</para>
        /// </description></item>
        /// <item><description><para><b>CONFIG_ONLY</b>: Stream delay is triggered only by the configuration. Parameters in the ingest URL are ignored.</para>
        /// </description></item>
        /// <item><description><para><b>PUBLISH_CONFIG</b>: Stream delay is triggered by both the configuration and parameters in the ingest URL. Parameters in the ingest URL have a higher priority than the configuration.</para>
        /// </description></item>
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
