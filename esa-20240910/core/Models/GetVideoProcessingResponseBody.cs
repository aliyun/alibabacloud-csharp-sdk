// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetVideoProcessingResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <para>The type of the configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: global configuration.</description></item>
        /// <item><description>rule: rule configuration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The custom end parameter for FLV files.</para>
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
        /// <para>FLV Seeking Valid values:</para>
        /// <list type="bullet">
        /// <item><description>by_byte: Seek by byte.</description></item>
        /// <item><description>by_time: Seek by time.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rule content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <para>Indicates whether the rule is enabled. Valid values:</para>
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
        /// <para>The name of the scaling rule.</para>
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
        /// <para>The version number of the website configurations.</para>
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
