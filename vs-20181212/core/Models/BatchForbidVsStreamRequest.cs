// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class BatchForbidVsStreamRequest : TeaModel {
        /// <summary>
        /// <para>The stream name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Format: AppName/StreamName.</description></item>
        /// <item><description>You can specify multiple stream names separated by commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live/stream1,live/stream2</para>
        /// </summary>
        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The stream control action. Set the value to forbid, which indicates that stream push is forbidden.</para>
        /// 
        /// <b>Example:</b>
        /// <para>forbid</para>
        /// </summary>
        [NameInMap("ControlStreamAction")]
        [Validation(Required=false)]
        public string ControlStreamAction { get; set; }

        /// <summary>
        /// <para>The accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether the stream is pushed by the streamer or pulled by the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>publisher: The stream is pushed by the streamer.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Currently, only publisher is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publisher</para>
        /// </summary>
        [NameInMap("LiveStreamType")]
        [Validation(Required=false)]
        public string LiveStreamType { get; set; }

        /// <summary>
        /// <para>Specifies whether to only interrupt the stream without adding it to the blacklist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>yes</description></item>
        /// <item><description>no</description></item>
        /// </list>
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

        /// <summary>
        /// <para>The time to resume the stream.</para>
        /// <remarks>
        /// <para>Specify the time in UTC format, for example, 2015-12-01T17:37:00Z.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-01T17:37:00Z</para>
        /// </summary>
        [NameInMap("ResumeTime")]
        [Validation(Required=false)]
        public string ResumeTime { get; set; }

    }

}
