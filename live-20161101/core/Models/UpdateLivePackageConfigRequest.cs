// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLivePackageConfigRequest : TeaModel {
        /// <summary>
        /// <para>The application name. The template applies only when this AppName matches the application name in the ingest URL. The AppName can be up to 255 characters and can contain digits, letters, hyphens (-), and underscores (_). It cannot start with a hyphen or an underscore. Set this parameter to an asterisk (\*) to match all application names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The primary domain name for live streaming playback.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies whether to ignore transcoded streams. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Ignore transcoded streams.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not ignore transcoded streams.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The duration of a part segment in milliseconds.</para>
        /// <remarks>
        /// <para>This parameter is required if you set \<c>Protocol\\</c> to \<c>LLHLS_\\*\\</c>.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If SegmentDuration is 1 s, the value can range from 100 to 500 ms.</para>
        /// </description></item>
        /// <item><description><para>If SegmentDuration is 2 s, the value can range from 100 to 1000 ms.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>350</para>
        /// </summary>
        [NameInMap("PartDuration")]
        [Validation(Required=false)]
        public int? PartDuration { get; set; }

        /// <summary>
        /// <para>The protocol and container format for live streaming. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HLS_CMAF</b></para>
        /// </description></item>
        /// <item><description><para><b>LLHLS_TS</b> (low latency)</para>
        /// </description></item>
        /// <item><description><para><b>LLHLS_CMAF</b> (low latency)</para>
        /// </description></item>
        /// <item><description><para><b>DASH_CMAF</b></para>
        /// </description></item>
        /// <item><description><para><b>HLSDASH_CMAF</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS_CMAF</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The segment duration in seconds.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set Protocol to HLS_CMAF, the value can range from 1 to 10 s.</para>
        /// </description></item>
        /// <item><description><para>If you set Protocol to LLHLS_\*, the value can range from 1 to 2 s.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

        /// <summary>
        /// <para>The number of M3U8 segments. The value must be an integer from 3 to 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentNum")]
        [Validation(Required=false)]
        public int? SegmentNum { get; set; }

        /// <summary>
        /// <para>The stream name. The template applies only when this StreamName matches the stream name in the ingest URL. The StreamName can be up to 255 characters and can contain digits, letters, hyphens (-), and underscores (_). It cannot start with a hyphen or an underscore. Set this parameter to an asterisk (\*) to match all stream names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StreamName</para>
        /// </summary>
        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

    }

}
