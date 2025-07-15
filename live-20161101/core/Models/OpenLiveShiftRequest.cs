// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class OpenLiveShiftRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. You can specify an asterisk (\*) as the value to match all applications under the domain name. You can view the application name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The length of a TS segment for HTTP Live Streaming (HLS). Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable time shifting for the transcoded stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: disables time shifting for the transcoded stream.</description></item>
        /// <item><description><b>false</b>: enables time shifting for the transcoded stream.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IgnoreTranscode")]
        [Validation(Required=false)]
        public bool? IgnoreTranscode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the live stream. You can specify an asterisk (\*) as the value to match all streams in the application. You can view the stream name on the <a href="https://help.aliyun.com/document_detail/197397.html">Stream Management</a> page of the ApsaraVideo Live console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The duration for which data is retained. Default value: 7. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Vision")]
        [Validation(Required=false)]
        public int? Vision { get; set; }

    }

}
