// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListProjectFeatureViewsResponseBody : TeaModel {
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListProjectFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListProjectFeatureViewsResponseBodyFeatureViews : TeaModel {
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<ListProjectFeatureViewsResponseBodyFeatureViewsFeatures> Features { get; set; }
            public class ListProjectFeatureViewsResponseBodyFeatureViewsFeatures : TeaModel {
                [NameInMap("Attributes")]
                [Validation(Required=false)]
                public List<string> Attributes { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
