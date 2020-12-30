// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPhysicalConnectionFeaturesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PhysicalConnectionFeatures")]
        [Validation(Required=false)]
        public List<ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures> PhysicalConnectionFeatures { get; set; }
        public class ListPhysicalConnectionFeaturesResponseBodyPhysicalConnectionFeatures : TeaModel {
            [NameInMap("FeatureValue")]
            [Validation(Required=false)]
            public string FeatureValue { get; set; }

            [NameInMap("FeatureKey")]
            [Validation(Required=false)]
            public string FeatureKey { get; set; }

        }

    }

}
