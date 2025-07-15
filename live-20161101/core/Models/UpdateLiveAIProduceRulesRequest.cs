// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveAIProduceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AppName</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The description of the subtitle rule. The description can be up to 128 characters in length and can contain letters, digits, and special characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>live AI subtitle template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The main streaming domain.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate live subtitles when stream pulling starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: generates live subtitles when stream pulling starts and stops generating live subtitles when no streams are pulled for 5 minutes. When stream pulling restarts, live subtitles are generated again.</description></item>
        /// <item><description>false: generates live subtitles when stream ingest starts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLazy")]
        [Validation(Required=false)]
        public bool? IsLazy { get; set; }

        /// <summary>
        /// <para>The specification of the output subtitles. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>lp_ld</c>: 360p (640 × 360)</description></item>
        /// <item><description><c>lp_ld_v</c>: 360p (360 × 640)</description></item>
        /// <item><description><c>lp_sd</c>: 480p (854 × 480)</description></item>
        /// <item><description><c>lp_sd_v</c>: 480p (480 × 854)</description></item>
        /// <item><description><c>lp_hd</c>: 720p (1280 × 720)</description></item>
        /// <item><description><c>lp_hd_v</c>: 720p (720 × 1280)</description></item>
        /// <item><description><c>lp_ud</c>: 1080p (1920 × 1080)</description></item>
        /// <item><description><c>lp_ud_v</c>: 1080p (1080 × 1920)</description></item>
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
        /// <para>The name of the virtual background template.</para>
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
