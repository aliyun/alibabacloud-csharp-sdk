// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListFeatureViewOnlineFeaturesResponseBody : TeaModel {
        [NameInMap("OnlineFeatures")]
        [Validation(Required=false)]
        public List<string> OnlineFeatures { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
