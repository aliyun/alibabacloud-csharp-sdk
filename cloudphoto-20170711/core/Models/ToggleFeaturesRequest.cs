// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ToggleFeaturesRequest : TeaModel {
        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

        [NameInMap("EnabledFeatures")]
        [Validation(Required=false)]
        public List<string> EnabledFeatures { get; set; }

        [NameInMap("DisabledFeatures")]
        [Validation(Required=false)]
        public List<string> DisabledFeatures { get; set; }

    }

}
