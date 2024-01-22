// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PriceEstimateOutput : TeaModel {
        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<PriceEstimateOutputApps> Apps { get; set; }
        public class PriceEstimateOutputApps : TeaModel {
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public PriceEstimateFeature Feature { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Usages")]
            [Validation(Required=false)]
            public List<PriceEstimateOutputAppsUsages> Usages { get; set; }
            public class PriceEstimateOutputAppsUsages : TeaModel {
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public float? Amount { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<PriceEstimateOutputItems> Items { get; set; }
        public class PriceEstimateOutputItems : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public float? Amount { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            [NameInMap("Steps")]
            [Validation(Required=false)]
            public List<PriceEstimateOutputItemsSteps> Steps { get; set; }
            public class PriceEstimateOutputItemsSteps : TeaModel {
                [NameInMap("Begin")]
                [Validation(Required=false)]
                public long? Begin { get; set; }

                [NameInMap("End")]
                [Validation(Required=false)]
                public long? End { get; set; }

                [NameInMap("Price")]
                [Validation(Required=false)]
                public float? Price { get; set; }

                [NameInMap("RegionIds")]
                [Validation(Required=false)]
                public List<string> RegionIds { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("TotalPrice")]
        [Validation(Required=false)]
        public float? TotalPrice { get; set; }

    }

}
