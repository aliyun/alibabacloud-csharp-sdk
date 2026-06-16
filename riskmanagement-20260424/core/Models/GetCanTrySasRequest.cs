// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetCanTrySasRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SdkRequest")]
        [Validation(Required=false)]
        public GetCanTrySasRequestSdkRequest SdkRequest { get; set; }
        public class GetCanTrySasRequestSdkRequest : TeaModel {
            [NameInMap("FromEcs")]
            [Validation(Required=false)]
            public bool? FromEcs { get; set; }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

        }

    }

}
