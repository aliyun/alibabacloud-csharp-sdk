// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned quota information.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetWafQuotaResponseBodyQuota Quota { get; set; }
        public class GetWafQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>The quota information for CAPTCHA rules.</para>
            /// </summary>
            [NameInMap("Captcha")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaCaptcha Captcha { get; set; }
            public class GetWafQuotaResponseBodyQuotaCaptcha : TeaModel {
                /// <summary>
                /// <para>Indicates whether CAPTCHA rules are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total quantity quota for CAPTCHA rules.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information for custom lists.</para>
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
                /// <para>The object that contains quota information for each item type in custom lists.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaListItemsValue> Items { get; set; }

                /// <summary>
                /// <para>The quantity quota for items in each custom list.</para>
                /// </summary>
                [NameInMap("NumberItemsPerList")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsPerList { get; set; }

                /// <summary>
                /// <para>The total quantity quota for items across all custom lists.</para>
                /// </summary>
                [NameInMap("NumberItemsTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsTotal { get; set; }

                /// <summary>
                /// <para>The total quantity quota for custom lists.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information for WAF managed rule groups.</para>
            /// </summary>
            [NameInMap("ManagedRulesGroup")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaManagedRulesGroup ManagedRulesGroup { get; set; }
            public class GetWafQuotaResponseBodyQuotaManagedRulesGroup : TeaModel {
                /// <summary>
                /// <para>Indicates whether WAF managed rule groups are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total quantity quota for WAF managed rule groups.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information for custom response pages.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaPage Page { get; set; }
            public class GetWafQuotaResponseBodyQuotaPage : TeaModel {
                /// <summary>
                /// <para>The object that contains quota information for each Content-Type in custom response pages.</para>
                /// </summary>
                [NameInMap("ContentTypes")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaPageContentTypesValue> ContentTypes { get; set; }

                /// <summary>
                /// <para>Indicates whether custom response pages are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total quantity quota for custom response pages.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information for scenario-specific protection rules.</para>
            /// </summary>
            [NameInMap("ScenePolicy")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaScenePolicy ScenePolicy { get; set; }
            public class GetWafQuotaResponseBodyQuotaScenePolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether the scenario-specific protection feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total quantity quota for scenario-specific protection rules.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota information for slider CAPTCHA pages.</para>
            /// </summary>
            [NameInMap("SliderCaptchaPage")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaSliderCaptchaPage SliderCaptchaPage { get; set; }
            public class GetWafQuotaResponseBodyQuotaSliderCaptchaPage : TeaModel {
                /// <summary>
                /// <para>Indicates whether slider CAPTCHA pages are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The quantity quota for slider CAPTCHA pages.</para>
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
