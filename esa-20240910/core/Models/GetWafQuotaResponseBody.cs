// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota information returned.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetWafQuotaResponseBodyQuota Quota { get; set; }
        public class GetWafQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>The quota information about custom lists.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaList List { get; set; }
            public class GetWafQuotaResponseBodyQuotaList : TeaModel {
                /// <summary>
                /// <para>Indicates whether custom lists are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The quota information about all item types in the custom lists.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaListItemsValue> Items { get; set; }

                /// <summary>
                /// <para>The maximum number of items in each custom list.</para>
                /// </summary>
                [NameInMap("NumberItemsPerList")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsPerList { get; set; }

                /// <summary>
                /// <para>The maximum number of items in all custom lists.</para>
                /// </summary>
                [NameInMap("NumberItemsTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsTotal { get; set; }

                /// <summary>
                /// <para>The maximum number of custom lists.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information about WAF managed rule groups.</para>
            /// </summary>
            [NameInMap("ManagedRulesGroup")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaManagedRulesGroup ManagedRulesGroup { get; set; }
            public class GetWafQuotaResponseBodyQuotaManagedRulesGroup : TeaModel {
                /// <summary>
                /// <para>Indicates whether the WAF managed rule group is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of WAF managed rule groups.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information about custom error pages.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaPage Page { get; set; }
            public class GetWafQuotaResponseBodyQuotaPage : TeaModel {
                /// <summary>
                /// <para>The quota information about custom error pages of all Content-Types.</para>
                /// </summary>
                [NameInMap("ContentTypes")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaPageContentTypesValue> ContentTypes { get; set; }

                /// <summary>
                /// <para>Indicates whether custom error pages are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of custom error pages.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information about scenario-specific policies.</para>
            /// </summary>
            [NameInMap("ScenePolicy")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaScenePolicy ScenePolicy { get; set; }
            public class GetWafQuotaResponseBodyQuotaScenePolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether scenario-specific policies are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of scenario-specific policies.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
