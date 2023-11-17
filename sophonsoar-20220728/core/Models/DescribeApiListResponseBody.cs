// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeApiListResponseBody : TeaModel {
        [NameInMap("ApiList")]
        [Validation(Required=false)]
        public List<DescribeApiListResponseBodyApiList> ApiList { get; set; }
        public class DescribeApiListResponseBodyApiList : TeaModel {
            [NameInMap("DocUrl")]
            [Validation(Required=false)]
            public string DocUrl { get; set; }

            [NameInMap("PopCode")]
            [Validation(Required=false)]
            public string PopCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
