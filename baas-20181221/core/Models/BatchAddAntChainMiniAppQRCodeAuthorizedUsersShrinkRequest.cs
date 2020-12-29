// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class BatchAddAntChainMiniAppQRCodeAuthorizedUsersShrinkRequest : TeaModel {
        [NameInMap("AntChainId")]
        [Validation(Required=false)]
        public string AntChainId { get; set; }

        [NameInMap("PhoneList")]
        [Validation(Required=false)]
        public string PhoneListShrink { get; set; }

    }

}
