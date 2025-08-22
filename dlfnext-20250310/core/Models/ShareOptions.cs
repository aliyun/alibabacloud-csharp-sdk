// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class ShareOptions : TeaModel {
        [NameInMap("catalogSizeLimit")]
        [Validation(Required=false)]
        public int? CatalogSizeLimit { get; set; }

        [NameInMap("receiverSizeLimit")]
        [Validation(Required=false)]
        public int? ReceiverSizeLimit { get; set; }

        [NameInMap("shareResourceSizeLimit")]
        [Validation(Required=false)]
        public int? ShareResourceSizeLimit { get; set; }

        [NameInMap("shareSizeLimit")]
        [Validation(Required=false)]
        public int? ShareSizeLimit { get; set; }

    }

}
