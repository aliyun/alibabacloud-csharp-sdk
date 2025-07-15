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
        /// <para>The configurations of the production studio. The following configurations are involved:</para>
        /// <list type="bullet">
        /// <item><description>CasterTemplate: required. The output resolution.</description></item>
        /// <item><description>LiveTemplate: optional. The templates to be used for transcoding.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Set the value to a JSON string. Use upper camel case for fields of the string.</para>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of on-demand media asset files in the playlist. Only on-demand video files are supported. You can specify up to three video files in the playlist. The video files in the playlist are automatically played in sequence. The playback stops at the point in time specified by the EndTime parameter.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can obtain the ID of a video file in the ApsaraVideo Live console or by calling an API operation. For more information, see <a href="https://help.aliyun.com/document_detail/86057.html">Media asset management</a> or <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a>. - If the video files are all played before the time specified by EndTime, the final frame of the final video file is played until the time specified by EndTime arrives.</description></item>
        /// </list>
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
