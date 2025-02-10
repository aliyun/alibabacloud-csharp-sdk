// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetOriginRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>352816096987136</para>
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
        /// <para>test.example.com</para>
        /// </summary>
        [NameInMap("DnsRecord")]
        [Validation(Required=false)]
        public string DnsRecord { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("OriginHttpPort")]
        [Validation(Required=false)]
        public string OriginHttpPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4433</para>
        /// </summary>
        [NameInMap("OriginHttpsPort")]
        [Validation(Required=false)]
        public string OriginHttpsPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("OriginScheme")]
        [Validation(Required=false)]
        public string OriginScheme { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>origin.example.com</para>
        /// </summary>
        [NameInMap("OriginSni")]
        [Validation(Required=false)]
        public string OriginSni { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
