// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListProductsResponseBody : TeaModel {
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyProducts> Products { get; set; }
        public class ListProductsResponseBodyProducts : TeaModel {
            [NameInMap("HasPermissionToPurchase")]
            [Validation(Required=false)]
            public bool? HasPermissionToPurchase { get; set; }

            [NameInMap("IsPurchased")]
            [Validation(Required=false)]
            public bool? IsPurchased { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductInstanceId")]
            [Validation(Required=false)]
            public string ProductInstanceId { get; set; }

            [NameInMap("PurchaseUrl")]
            [Validation(Required=false)]
            public string PurchaseUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListProductsResponseBodyServices> Services { get; set; }
        public class ListProductsResponseBodyServices : TeaModel {
            [NameInMap("IsOpen")]
            [Validation(Required=false)]
            public bool? IsOpen { get; set; }

            [NameInMap("OpenUrl")]
            [Validation(Required=false)]
            public string OpenUrl { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

        }

    }

}
