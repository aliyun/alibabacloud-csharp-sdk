// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCompressionRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Brotli")]
        [Validation(Required=false)]
        public string Brotli { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35281609698****</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public long? ConfigId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Gzip")]
        [Validation(Required=false)]
        public string Gzip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>186C6DF2-D96A-5102-B04E-FB92C16C9867</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>(http.host eq &quot;video.example.com&quot;)</para>
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
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

        [NameInMap("Zstd")]
        [Validation(Required=false)]
        public string Zstd { get; set; }

    }

}
