// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAIProduceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the live stream application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The description of the subtitle rule. The description can contain letters, digits, Chinese characters, and special characters, and can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The primary streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether subtitles are triggered by stream pulling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Subtitles start when a stream is pulled. If no stream is pulled within 5 minutes, the subtitles stop. Subtitles restart when a stream is pulled again.</description></item>
        /// <item><description>false: Subtitles start as long as stream ingest is active, regardless of whether a stream is being pulled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLazy")]
        [Validation(Required=false)]
        public bool? IsLazy { get; set; }

        /// <summary>
        /// <para>The output specification of the subtitle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Landscape low definition 360P 640 × 360: <c>lp_ld</c></description></item>
        /// <item><description>Portrait low definition 360P 360 × 640: <c>lp_ld_v</c></description></item>
        /// <item><description>Landscape standard definition 480P 854 × 480: <c>lp_sd</c></description></item>
        /// <item><description>Portrait standard definition 480P 480 × 854: <c>lp_sd_v</c></description></item>
        /// <item><description>Landscape high definition 720P 1280 × 720: <c>lp_hd</c></description></item>
        /// <item><description>Portrait high definition 720P 720 × 1280: <c>lp_hd_v</c></description></item>
        /// <item><description>Landscape ultra-high definition 1080P 1920 × 1080: <c>lp_ud</c></description></item>
        /// <item><description>Portrait ultra-high definition 1080P 1080 × 1920: <c>lp_ud_v</c></description></item>
        /// </list>
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
        /// <para>The ID of the subtitle rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d -8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("RulesId")]
        [Validation(Required=false)]
        public string RulesId { get; set; }

        /// <summary>
        /// <para>The name of the virtual background template. You must specify at least one of SubtitleName and StudioName. Otherwise, a MissingParameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

        /// <summary>
        /// <para>The ID of the subtitle template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("SubtitleId")]
        [Validation(Required=false)]
        public string SubtitleId { get; set; }

        /// <summary>
        /// <para>The name of the subtitle template. You must specify at least one of SubtitleName and StudioName. Otherwise, a MissingParameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sub01</para>
        /// </summary>
        [NameInMap("SubtitleName")]
        [Validation(Required=false)]
        public string SubtitleName { get; set; }

        /// <summary>
        /// <para>The suffix match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("Suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

    }

}
