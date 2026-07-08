// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class UpdateVsPullStreamInfoConfigRequest : TeaModel {
        [NameInMap("Always")]
        [Validation(Required=false)]
        public string Always { get; set; }

        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Your stream pulling domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end time of stream pulling.</para>
        /// <remarks>
        /// <para>UTC time format. The interval between StartTime and EndTime must be within 7 days, and EndTime must be later than the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2018-12-10T18:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The origin server of your live stream.</para>
        /// <remarks>
        /// <para>Supports multiple values, separated by English semicolons (;).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up.xxx.com.cn</para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <para>The start time of stream pulling.</para>
        /// <remarks>
        /// <para>UTC time format. The interval between StartTime and EndTime must be within 7 days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T10:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The name of the live stream.</para>
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
