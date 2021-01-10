// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ConfirmAKSProductsEnabledResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ConfirmAKSProductsEnabledResponseBodyData> Data { get; set; }
        public class ConfirmAKSProductsEnabledResponseBodyData : TeaModel {
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
