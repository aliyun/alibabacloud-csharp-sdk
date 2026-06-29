// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListVideoProcessingsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of configurations.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListVideoProcessingsResponseBodyConfigs> Configs { get; set; }
        public class ListVideoProcessingsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <para>The configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234123**</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <para>The configuration type. Valid values:</para>
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
            /// <para>The rule content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
            /// </summary>
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public string Rule { get; set; }

            /// <summary>
            /// <para>The rule switch. Valid values:</para>
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
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule_example</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The execution order of the rule. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sequence")]
            [Validation(Required=false)]
            public int? Sequence { get; set; }

            /// <summary>
            /// <para>The version number of the site configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <para>The audio seeking switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>on: enabled.</para>
            /// </description></item>
            /// <item><description><para>off: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("VideoSeekEnable")]
            [Validation(Required=false)]
            public string VideoSeekEnable { get; set; }

        }

        /// <summary>
        /// <para>The current page number, which is the same as the PageNumber request parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>55</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
