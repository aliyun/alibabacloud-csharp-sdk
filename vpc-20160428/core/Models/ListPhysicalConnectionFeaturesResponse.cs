// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListPhysicalConnectionFeaturesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PhysicalConnectionFeatures")]
        [Validation(Required=true)]
        public List<ListPhysicalConnectionFeaturesResponsePhysicalConnectionFeatures> PhysicalConnectionFeatures { get; set; }
        public class ListPhysicalConnectionFeaturesResponsePhysicalConnectionFeatures : TeaModel {
            [NameInMap("FeatureKey")]
            [Validation(Required=true)]
            public string FeatureKey { get; set; }

            [NameInMap("FeatureValue")]
            [Validation(Required=true)]
            public string FeatureValue { get; set; }

        }

    }

}
