// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateProductSpecsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProductSpecsId")]
        [Validation(Required=false)]
        public long? ProductSpecsId { get; set; }

        [NameInMap("ProductSpecsCode")]
        [Validation(Required=false)]
        public string ProductSpecsCode { get; set; }

    }

}
