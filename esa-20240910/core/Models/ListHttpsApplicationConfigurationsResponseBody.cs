// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListHttpsApplicationConfigurationsResponseBody : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<ListHttpsApplicationConfigurationsResponseBodyConfigs> Configs { get; set; }
        public class ListHttpsApplicationConfigurationsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvc")]
            [Validation(Required=false)]
            public string AltSvc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcClear")]
            [Validation(Required=false)]
            public string AltSvcClear { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("AltSvcMa")]
            [Validation(Required=false)]
            public string AltSvcMa { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("AltSvcPersist")]
            [Validation(Required=false)]
            public string AltSvcPersist { get; set; }

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
            /// <para>on</para>
            /// </summary>
            [NameInMap("Hsts")]
            [Validation(Required=false)]
            public string Hsts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsIncludeSubdomains")]
            [Validation(Required=false)]
            public string HstsIncludeSubdomains { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public string HstsMaxAge { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public string HstsPreload { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("HttpsForce")]
            [Validation(Required=false)]
            public string HttpsForce { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>301</para>
            /// </summary>
            [NameInMap("HttpsForceCode")]
            [Validation(Required=false)]
            public string HttpsForceCode { get; set; }

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
        /// <para>16</para>
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
