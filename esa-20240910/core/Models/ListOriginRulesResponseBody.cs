// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListOriginRulesResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListOriginRulesResponseBodyConfigs> Configs { get; set; }
        public class ListOriginRulesResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>395386449776640</para>
            /// </summary>
            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>global</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
