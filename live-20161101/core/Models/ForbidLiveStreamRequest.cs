// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ForbidLiveStreamRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the ingest stream belongs. You can view the AppName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
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
        /// <para>Specifies whether to disable stream ingest or streaming. Currently, only disabling stream ingest is supported: <b>publisher</b>.</para>
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
        /// <item><description><para><b>yes</b>: Only interrupts the stream without adding it to the blacklist (supports upstream ingest or upstream streaming).</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: Interrupts the stream and adds it to the blacklist.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: no.</para>
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
        /// <para>The time to resume the stream. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the <b>Oneshot</b> parameter is set to <b>no</b> and ResumeTime is not specified, the live stream is disabled for 6 months by default.</description></item>
        /// <item><description>If a value is specified, the restriction is lifted at the time specified by ResumeTime and the live stream is resumed.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-01T10:37:00Z</para>
        /// </summary>
        [NameInMap("ResumeTime")]
        [Validation(Required=false)]
        public string ResumeTime { get; set; }

        /// <summary>
        /// <para>The name of the ingest stream. You can view the StreamName on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page.</para>
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
