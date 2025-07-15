// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ForbidLiveStreamRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The ingest domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether the live stream is ingested by a streamer or played by a viewer. Set the value to <b>publisher</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publisher</para>
        /// </summary>
        [NameInMap("LiveStreamType")]
        [Validation(Required=false)]
        public string LiveStreamType { get; set; }

        /// <summary>
        /// <para>Specifies whether to only interrupt the live stream without adding the ingest URL of the live stream to the blacklist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: interrupts the live stream but does not add the ingest URL of the live stream to the blacklist. This value is available only when the live stream is ingested or played in the upstream.</description></item>
        /// <item><description><b>no</b>: disables the live stream and adds the ingest URL of the live stream to the blacklist.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value no is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Oneshot")]
        [Validation(Required=false)]
        public string Oneshot { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The time when the live stream is resumed. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>Oneshot</b> parameter to <b>no</b> and do not specify this parameter, the live stream is disabled for six months by default.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the live stream is resumed at the specified point in time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-01T10:37:00Z</para>
        /// </summary>
        [NameInMap("ResumeTime")]
        [Validation(Required=false)]
        public string ResumeTime { get; set; }

        /// <summary>
        /// <para>The name of the ingested stream. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
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
