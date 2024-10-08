// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafQuotaResponseBody : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetWafQuotaResponseBodyQuota Quota { get; set; }
        public class GetWafQuotaResponseBodyQuota : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaList List { get; set; }
            public class GetWafQuotaResponseBodyQuotaList : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaListItemsValue> Items { get; set; }

                [NameInMap("NumberItemsPerList")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsPerList { get; set; }

                [NameInMap("NumberItemsTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberItemsTotal { get; set; }

                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            [NameInMap("ManagedRulesGroup")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaManagedRulesGroup ManagedRulesGroup { get; set; }
            public class GetWafQuotaResponseBodyQuotaManagedRulesGroup : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaPage Page { get; set; }
            public class GetWafQuotaResponseBodyQuotaPage : TeaModel {
                [NameInMap("ContentTypes")]
                [Validation(Required=false)]
                public Dictionary<string, QuotaPageContentTypesValue> ContentTypes { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

            [NameInMap("ScenePolicy")]
            [Validation(Required=false)]
            public GetWafQuotaResponseBodyQuotaScenePolicy ScenePolicy { get; set; }
            public class GetWafQuotaResponseBodyQuotaScenePolicy : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("NumberTotal")]
                [Validation(Required=false)]
                public WafQuotaInteger NumberTotal { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
