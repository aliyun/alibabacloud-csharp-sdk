// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListRedirectRulesResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListRedirectRulesResponseBodyConfigs> Configs { get; set; }
        public class ListRedirectRulesResponseBodyConfigs : TeaModel {
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
            [NameInMap("ReserveQueryString")]
            [Validation(Required=false)]
            public string ReserveQueryString { get; set; }

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
            /// <para>1</para>
            /// </summary>
            [NameInMap("SiteVersion")]
            [Validation(Required=false)]
            public int? SiteVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.exapmle.com/index.html">http://www.exapmle.com/index.html</a></para>
            /// </summary>
            [NameInMap("TargetUrl")]
            [Validation(Required=false)]
            public string TargetUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>static</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
