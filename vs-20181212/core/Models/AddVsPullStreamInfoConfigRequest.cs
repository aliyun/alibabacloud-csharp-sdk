// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class AddVsPullStreamInfoConfigRequest : TeaModel {
        [NameInMap("Always")]
        [Validation(Required=false)]
        public string Always { get; set; }

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
        /// <para>The end time for stream pulling.</para>
        /// <remarks>
        /// <para>The time must be in UTC format. The interval between StartTime and EndTime cannot exceed 7 days. EndTime must be later than the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-28T09:30:30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The source URL of the live stream.</para>
        /// <remarks>
        /// <para>Multiple source URLs are supported. Separate them with semicolons (;).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up.******.com.cn</para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <para>The start time for stream pulling.</para>
        /// <remarks>
        /// <para>The time must be in UTC format. The interval between StartTime and EndTime cannot exceed 7 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-28T07:30:30Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

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
