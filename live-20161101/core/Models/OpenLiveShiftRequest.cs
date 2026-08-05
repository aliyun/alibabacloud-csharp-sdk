// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class OpenLiveShiftRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application. The wildcard character (\<em>) is supported. An asterisk (\</em>) represents all applications under the specified domain name. For more information, see <a href="https://help.aliyun.com/document_detail/197397.html">Stream management</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The duration of an HTTP Live Streaming (HLS) transport stream (TS) segment. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable time shifting for transcoded streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Time shifting is disabled for transcoded streams.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Time shifting is enabled for transcoded streams.</para>
        /// </description></item>
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
        /// <para>The name of the stream. The wildcard character (\<em>) is supported. An asterisk (\</em>) represents all streams under the specified application. For more information, see <a href="https://help.aliyun.com/document_detail/197397.html">Stream management</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// <para>The data retention period. The default value is 7. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Vision")]
        [Validation(Required=false)]
        public int? Vision { get; set; }

    }

}
