// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListSmartAGApiUnsupportedFeatureResponseBody : TeaModel {
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<ListSmartAGApiUnsupportedFeatureResponseBodyFeatures> Features { get; set; }
        public class ListSmartAGApiUnsupportedFeatureResponseBodyFeatures : TeaModel {
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
