// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListModelFeatureAvailableFeaturesResponseBody : TeaModel {
        [NameInMap("AvaliableFeatures")]
        [Validation(Required=false)]
        public List<ListModelFeatureAvailableFeaturesResponseBodyAvaliableFeatures> AvaliableFeatures { get; set; }
        public class ListModelFeatureAvailableFeaturesResponseBodyAvaliableFeatures : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SourceName")]
            [Validation(Required=false)]
            public string SourceName { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
