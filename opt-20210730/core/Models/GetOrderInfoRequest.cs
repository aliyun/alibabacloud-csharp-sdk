// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Opt20210730.Models
{
    public class GetOrderInfoRequest : TeaModel {
        [NameInMap("RelService")]
        [Validation(Required=false)]
        public string RelService { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

    }

}
