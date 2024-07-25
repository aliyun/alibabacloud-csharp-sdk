// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CancelFavoritePublicMediaResponseBody : TeaModel {
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
