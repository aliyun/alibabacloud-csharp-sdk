// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateVideoProcessingRequest : TeaModel {
        /// <summary>
        /// <para>The configuration ID. You can call the <a href="~~ListVideoProcessings~~">ListVideoProcessings</a> operation to obtain the configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The custom FLV end parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("FlvSeekEnd")]
        [Validation(Required=false)]
        public string FlvSeekEnd { get; set; }

        /// <summary>
        /// <para>The custom FLV start parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("FlvSeekStart")]
        [Validation(Required=false)]
        public string FlvSeekStart { get; set; }

        /// <summary>
        /// <para>The FLV seeking mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>by_byte: seek by byte.</description></item>
        /// <item><description>by_time: seek by time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>by_byte</para>
        /// </summary>
        [NameInMap("FlvVideoSeekMode")]
        [Validation(Required=false)]
        public string FlvVideoSeekMode { get; set; }

        /// <summary>
        /// <para>The custom MP4 end parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("Mp4SeekEnd")]
        [Validation(Required=false)]
        public string Mp4SeekEnd { get; set; }

        /// <summary>
        /// <para>The custom MP4 start parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Mp4SeekStart")]
        [Validation(Required=false)]
        public string Mp4SeekStart { get; set; }

        /// <summary>
        /// <para>The rule content, which uses a conditional expression to match user requests. You do not need to set this parameter when adding a global configuration. Two scenarios are supported:</para>
        /// <list type="bullet">
        /// <item><description>Match all incoming requests: set the value to true.</description></item>
        /// <item><description>Match specified requests: set the value to a custom expression, such as (http.host eq \&quot;video.example.com\&quot;).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>The rule switch. You do not need to set this parameter when adding a global configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The rule name. You do not need to set this parameter when adding a global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule execution order. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the video seeking feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on: enabled.</description></item>
        /// <item><description>off: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoSeekEnable")]
        [Validation(Required=false)]
        public string VideoSeekEnable { get; set; }

    }

}
