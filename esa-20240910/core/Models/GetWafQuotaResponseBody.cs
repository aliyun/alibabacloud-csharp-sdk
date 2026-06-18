// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The quota details.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetWafQuotaResponseBodyQuota Quota { get; set; }
        public class GetWafQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>The quota for captcha rules.</para>
            /// </summary>
            [NameInMap("Captcha")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaCaptcha Captcha { get; set; }
            public class GetWafQuotaResponseBodyQuotaCaptcha : TeaModel {
                /// <summary>
                /// <para>Whether captcha rules are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of captcha rules allowed.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota for custom lists.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaList List { get; set; }
            public class GetWafQuotaResponseBodyQuotaList : TeaModel {
                /// <summary>
                /// <para>Whether the custom list feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The quota for each item type in a custom list.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaListItemsValue> Items { get; set; }

                /// <summary>
                /// <para>The maximum number of items allowed per custom list.</para>
                /// </summary>
                [NameInMap("NumberItemsPerList")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsPerList { get; set; }

                /// <summary>
                /// <para>The maximum number of items allowed across all custom lists.</para>
                /// </summary>
                [NameInMap("NumberItemsTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsTotal { get; set; }

                /// <summary>
                /// <para>The maximum number of custom lists allowed.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota for WAF managed rule groups.</para>
            /// </summary>
            [NameInMap("ManagedRulesGroup")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaManagedRulesGroup ManagedRulesGroup { get; set; }
            public class GetWafQuotaResponseBodyQuotaManagedRulesGroup : TeaModel {
                /// <summary>
                /// <para>Whether the WAF managed rule group feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of WAF managed rule groups allowed.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota for custom response pages.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaPage Page { get; set; }
            public class GetWafQuotaResponseBodyQuotaPage : TeaModel {
                /// <summary>
                /// <para>The quota for each Content-Type in a custom response page.</para>
                /// </summary>
                [NameInMap("ContentTypes")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaPageContentTypesValue> ContentTypes { get; set; }

                /// <summary>
                /// <para>Whether the custom response page feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of custom response pages allowed.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota for scenario protection.</para>
            /// </summary>
            [NameInMap("ScenePolicy")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaScenePolicy ScenePolicy { get; set; }
            public class GetWafQuotaResponseBodyQuotaScenePolicy : TeaModel {
                /// <summary>
                /// <para>Whether the scenario protection feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The maximum number of scenario protection rules allowed.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>The quota for slider captcha pages.</para>
            /// </summary>
            [NameInMap("SliderCaptchaPage")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaSliderCaptchaPage SliderCaptchaPage { get; set; }
            public class GetWafQuotaResponseBodyQuotaSliderCaptchaPage : TeaModel {
                /// <summary>
                /// <para>Whether slider captcha pages are enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

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
