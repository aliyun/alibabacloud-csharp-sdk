// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned quota information.</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetWafQuotaResponseBodyQuota Quota { get; set; }
        public class GetWafQuotaResponseBodyQuota : TeaModel {
            /// <summary>
            /// <para>Quota information related to custom lists.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaList List { get; set; }
            public class GetWafQuotaResponseBodyQuotaList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the custom list is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>An object containing quota information for each type of item in the custom list.</para>
                /// </summary>
                [NameInMap("Items")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaListItemsValue> Items { get; set; }

                /// <summary>
                /// <para>The number quota allowed per custom list.</para>
                /// </summary>
                [NameInMap("NumberItemsPerList")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsPerList { get; set; }

                /// <summary>
                /// <para>The total number quota allowed for items in all custom lists.</para>
                /// </summary>
                [NameInMap("NumberItemsTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsTotal { get; set; }

                /// <summary>
                /// <para>The total number quota allowed for custom lists.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>Quota information related to the WAF managed rules group.</para>
            /// </summary>
            [NameInMap("ManagedRulesGroup")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaManagedRulesGroup ManagedRulesGroup { get; set; }
            public class GetWafQuotaResponseBodyQuotaManagedRulesGroup : TeaModel {
                /// <summary>
                /// <para>Indicates whether the WAF managed rules group is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total number quota allowed for the WAF managed rules group.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>Quota information related to custom response pages.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaPage Page { get; set; }
            public class GetWafQuotaResponseBodyQuotaPage : TeaModel {
                /// <summary>
                /// <para>An object containing quota information for each Content-Type in custom response pages.</para>
                /// </summary>
                [NameInMap("ContentTypes")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaPageContentTypesValue> ContentTypes { get; set; }

                /// <summary>
                /// <para>Indicates whether the custom response page is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total number quota allowed for custom response pages.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            /// <summary>
            /// <para>Quota information related to scene protection.</para>
            /// </summary>
            [NameInMap("ScenePolicy")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaScenePolicy ScenePolicy { get; set; }
            public class GetWafQuotaResponseBodyQuotaScenePolicy : TeaModel {
                /// <summary>
                /// <para>Indicates whether the scene protection feature is enabled.</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The total number quota for scene protection rules.</para>
                /// </summary>
                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
