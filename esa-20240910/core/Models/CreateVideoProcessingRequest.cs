// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateVideoProcessingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("FlvSeekEnd")]
        [Validation(Required=false)]
        public string FlvSeekEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("FlvSeekStart")]
        [Validation(Required=false)]
        public string FlvSeekStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>by_byte</para>
        /// </summary>
        [NameInMap("FlvVideoSeekMode")]
        [Validation(Required=false)]
        public string FlvVideoSeekMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>end</para>
        /// </summary>
        [NameInMap("Mp4SeekEnd")]
        [Validation(Required=false)]
        public string Mp4SeekEnd { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Mp4SeekStart")]
        [Validation(Required=false)]
        public string Mp4SeekStart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>(http.host eq \&quot;video.example.com\&quot;)</para>
        /// </summary>
        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("RuleEnable")]
        [Validation(Required=false)]
        public string RuleEnable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rule_example</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("VideoSeekEnable")]
        [Validation(Required=false)]
        public string VideoSeekEnable { get; set; }

    }

}
