// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardDayUsagesResponseBody : TeaModel {
        [NameInMap("Cards")]
        [Validation(Required=false)]
        public List<ListCardDayUsagesResponseBodyCards> Cards { get; set; }
        public class ListCardDayUsagesResponseBodyCards : TeaModel {
            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }

            [NameInMap("UsageDataMonths")]
            [Validation(Required=false)]
            public List<ListCardDayUsagesResponseBodyCardsUsageDataMonths> UsageDataMonths { get; set; }
            public class ListCardDayUsagesResponseBodyCardsUsageDataMonths : TeaModel {
                [NameInMap("CardDayUsages")]
                [Validation(Required=false)]
                public List<ListCardDayUsagesResponseBodyCardsUsageDataMonthsCardDayUsages> CardDayUsages { get; set; }
                public class ListCardDayUsagesResponseBodyCardsUsageDataMonthsCardDayUsages : TeaModel {
                    [NameInMap("Day")]
                    [Validation(Required=false)]
                    public string Day { get; set; }

                    [NameInMap("UsageData")]
                    [Validation(Required=false)]
                    public string UsageData { get; set; }

                }

                [NameInMap("Month")]
                [Validation(Required=false)]
                public string Month { get; set; }

                [NameInMap("UsageDataMonth")]
                [Validation(Required=false)]
                public string UsageDataMonth { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
