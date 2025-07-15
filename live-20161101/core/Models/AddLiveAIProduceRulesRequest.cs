// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveAIProduceRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs. The name can be up to 256 characters in length and can contain digits, letters, hyphens (-), and underscores (_). The name must be the same as the application name in the ingest URL. Otherwise, the rule does not take effect.</para>
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
        /// <para>Specifies whether to trigger the subtitle rule when stream pulling starts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: generates live subtitles when stream pulling starts and stops generating live subtitles when no stream is pulled for 5 minutes. When stream pulling restarts, live subtitles are generated again.</description></item>
        /// <item><description>false: generates live subtitles when stream ingest starts, regardless of whether stream pulling starts.</description></item>
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
        /// <item><description><c>lp_ld</c>: landscape low definition 360p (640×360)</description></item>
        /// <item><description><c>lp_ld_v</c>: portrait low definition 360p (360×640)</description></item>
        /// <item><description><c>lp_sd</c>: landscape standard definition 480p (854×480)</description></item>
        /// <item><description><c>lp_sd_v</c>: portrait standard definition 480p (480×854)</description></item>
        /// <item><description><c>lp_hd</c>: landscape high definition 720p (1280×720)</description></item>
        /// <item><description><c>lp_hd_v</c>: portrait high definition 720p (720×1280)</description></item>
        /// <item><description><c>lp_ud</c>: landscape ultra-high definition 1080p (1920×1080)</description></item>
        /// <item><description><c>lp_ud_v</c>: portrait ultra-high definition 1080p (1080×1920)</description></item>
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
