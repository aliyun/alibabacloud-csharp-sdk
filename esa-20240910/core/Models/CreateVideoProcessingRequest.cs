// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateVideoProcessingRequest : TeaModel {
        /// <summary>
        /// <para>Set custom end parameters for FLV files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("FlvSeekEnd")]
        [Validation(Required=false)]
        public string FlvSeekEnd { get; set; }

        /// <summary>
        /// <para>The custom start parameter for FLV files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("FlvSeekStart")]
        [Validation(Required=false)]
        public string FlvSeekStart { get; set; }

        /// <summary>
        /// <para>FLV seeking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>by_byte: seek by byte</description></item>
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
        /// <para>Customize the mp4 end parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("Mp4SeekEnd")]
        [Validation(Required=false)]
        public string Mp4SeekEnd { get; set; }

        /// <summary>
        /// <para>Customize the mp4 start parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Mp4SeekStart")]
        [Validation(Required=false)]
        public string Mp4SeekStart { get; set; }

        /// <summary>
        /// <para>The content of the rule. A conditional expression is used to match a user request. You do not need to set this parameter when you add global configuration. Use cases:</para>
        /// <list type="bullet">
        /// <item><description>true: Match all incoming requests.</description></item>
        /// <item><description>Set the value to a custom expression, for example:(http.host eq &quot;video.example.com&quot;): Match the specified request.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the rule. Valid values: You do not need to set this parameter when you add global configuration. Specifies whether to check the image used by the instance supports hot migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <para>The name of the scheduling rule. You do not need to set this parameter when you add global configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The order in which the rule is executed. A smaller value gives priority to the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The version number of the website configurations. You can use this parameter to specify a version of your website to apply the feature settings. By default, version 0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <para>Video seeking. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>on</description></item>
        /// <item><description>off</description></item>
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
