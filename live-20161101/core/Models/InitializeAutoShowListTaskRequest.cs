// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class InitializeAutoShowListTaskRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http://***.com/callback</para>
        /// </summary>
        [NameInMap("CallBackUrl")]
        [Validation(Required=false)]
        public string CallBackUrl { get; set; }

        /// <summary>
        /// <para>The production studio configuration. This includes:</para>
        /// <list type="bullet">
        /// <item><description><para>(Required) CasterTemplate: the output resolution of the production studio.</para>
        /// </description></item>
        /// <item><description><para>(Optional) LiveTemplate: the list of output transcoding tasks.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>A JSON-formatted string. Use upper camel case (PascalCase) for the field names within the struct.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CasterTemplate&quot;: &quot;lp_ld&quot;,&quot;LiveTemplates&quot;:[&quot;lhd&quot;, &quot;lsd&quot;,&quot;lud&quot;]}</para>
        /// </summary>
        [NameInMap("CasterConfig")]
        [Validation(Required=false)]
        public string CasterConfig { get; set; }

        /// <summary>
        /// <para>The output streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645688994000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>The list of video-on-demand media asset file IDs in the playlist. Currently, only MP4 video files from the video-on-demand platform are supported.</para>
        /// <para>A maximum of three programs are supported. Each program is played in the order of the list until EndTime, at which point playback automatically ends. This parameter is required. If it is missing, a MissingParameter error is returned.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can obtain the video file ID from the console or from the response parameters of an API operation. For more information, see <a href="https://help.aliyun.com/document_detail/86057.html">Media asset management</a> or <a href="https://help.aliyun.com/document_detail/55407.html">Obtain the upload URL and credential for audio and video files</a>.- If all programs finish playing before EndTime, the last frame of the last program is displayed until the scheduled end time.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;89e02xxxxfb349axxxxa0c350d****  &quot;,&quot;6ae0xxxxxb349axxxxa0c350a****&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The start timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645688994000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
