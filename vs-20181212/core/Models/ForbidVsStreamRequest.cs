// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ForbidVsStreamRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The stream control action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>forbid</b>: Disables the stream.</description></item>
        /// </list>
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
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The live stream type. Valid values: publisher.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publisher</para>
        /// </summary>
        [NameInMap("LiveStreamType")]
        [Validation(Required=false)]
        public string LiveStreamType { get; set; }

        /// <summary>
        /// <para>Specifies whether to only interrupt the stream without adding it to the blacklist. Valid values: yes: Interrupts the stream without adding it to the blacklist.</para>
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
        /// <para>The time to resume the stream in UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-01T17:37:00Z</para>
        /// </summary>
        [NameInMap("ResumeTime")]
        [Validation(Required=false)]
        public string ResumeTime { get; set; }

        /// <summary>
        /// <para>The stream name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxStream</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
