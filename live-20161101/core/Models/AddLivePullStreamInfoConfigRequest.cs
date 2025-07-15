// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLivePullStreamInfoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. This parameter is determined by you.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The domain name used for stream pulling. It is the main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The time when stream pulling ends.</para>
        /// <para>The time range specified by the StartTime and EndTime parameters cannot exceed seven days. The time specified by the EndTime parameter must be later than the current time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-22T08:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The origin URL of the live stream. You can specify multiple URLs. Separate them with semicolons (;).</para>
        /// <remarks>
        /// <para> You can pull only live streams in the Real-Time Messaging Protocol (RTMP), Flash Video (FLV), HTTP Live Streaming (HLS), and Secure Reliable Transport (SRT) formats.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <para>The time when stream pulling starts.</para>
        /// <para>The time range specified by the StartTime and EndTime parameters cannot exceed seven days. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream. This parameter is determined by you.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
