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
        /// <item><description><para>Format: AppName/StreamName.</para>
        /// </description></item>
        /// <item><description><para>Specify multiple names, separated by commas (,).</para>
        /// </description></item>
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

        [NameInMap("ControlStreamAction")]
        [Validation(Required=false)]
        public string ControlStreamAction { get; set; }

        /// <summary>
        /// <para>Your accelerated domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether the operation applies to stream ingest by a streamer or stream pulling by a client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>publisher (streamer ingest)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only publisher is supported.</para>
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
        /// <para>Specifies whether to stop ingest without adding the stream to the blacklist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>yes</para>
        /// </description></item>
        /// <item><description><para>no</para>
        /// </description></item>
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
        /// <para>The time to resume ingest.</para>
        /// <remarks>
        /// <para>Use UTC format. Example: 2015-12-01T17:37:00Z</para>
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
