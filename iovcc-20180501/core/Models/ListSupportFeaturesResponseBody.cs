// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListSupportFeaturesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportFeatures")]
        [Validation(Required=false)]
        public List<ListSupportFeaturesResponseBodySupportFeatures> SupportFeatures { get; set; }
        public class ListSupportFeaturesResponseBodySupportFeatures : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
