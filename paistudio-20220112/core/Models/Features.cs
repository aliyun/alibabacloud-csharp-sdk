// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class Features : TeaModel {
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public FeaturesQuota Quota { get; set; }
        public class FeaturesQuota : TeaModel {
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public bool? IsEnabled { get; set; }

        }

    }

}
