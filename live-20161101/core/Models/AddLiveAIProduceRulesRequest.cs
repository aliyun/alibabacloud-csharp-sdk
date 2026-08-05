// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAIProduceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the live streaming application. The name can be up to 256 characters long and can contain digits, uppercase and lowercase letters, hyphens (-), and underscores (_). The AppName must match the AppName in the ingest URL for the template to take effect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The description of the subtitle rule. The description can contain Chinese and English characters, digits, and special characters. It can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is triggered by stream pulling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Subtitles are generated when stream pulling starts. If no stream is pulled for 5 minutes, subtitle generation stops. Subtitle generation resumes when stream pulling starts again.</para>
        /// </description></item>
        /// <item><description><para>false: Subtitles are generated when stream ingest starts, regardless of whether a stream is being pulled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLazy")]
        [Validation(Required=false)]
        public bool? IsLazy { get; set; }

        /// <summary>
        /// <para>The specifications of the output subtitles. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Landscape low definition 360p (640 × 360): <c>lp_ld</c></para>
        /// </description></item>
        /// <item><description><para>Portrait low definition 360p (360 × 640): <c>lp_ld_v</c></para>
        /// </description></item>
        /// <item><description><para>Landscape standard definition 480p (854 × 480): <c>lp_sd</c></para>
        /// </description></item>
        /// <item><description><para>Portrait standard definition 480p (480 × 854): <c>lp_sd_v</c></para>
        /// </description></item>
        /// <item><description><para>Landscape high definition 720p (1280 × 720): <c>lp_hd</c></para>
        /// </description></item>
        /// <item><description><para>Portrait high definition 720p (720 × 1280): <c>lp_hd_v</c></para>
        /// </description></item>
        /// <item><description><para>Landscape ultra high definition 1080p (1920 × 1080): <c>lp_ud</c></para>
        /// </description></item>
        /// <item><description><para>Portrait ultra high definition 1080p (1080 × 1920): <c>lp_ud_v</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lp_ld</para>
        /// </summary>
        [NameInMap("LiveTemplate")]
        [Validation(Required=false)]
        public string LiveTemplate { get; set; }

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
        /// <para>The name of the virtual background template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

        /// <summary>
        /// <para>The suffix to match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

    }

}
