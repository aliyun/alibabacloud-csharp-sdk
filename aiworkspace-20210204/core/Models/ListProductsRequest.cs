// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListProductsRequest : TeaModel {
        [NameInMap("ProductCodes")]
        [Validation(Required=false)]
        public string ProductCodes { get; set; }

        [NameInMap("ServiceCodes")]
        [Validation(Required=false)]
        public string ServiceCodes { get; set; }

        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
