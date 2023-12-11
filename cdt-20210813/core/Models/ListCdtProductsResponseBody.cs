// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDT20210813.Models
{
    public class ListCdtProductsResponseBody : TeaModel {
        [NameInMap("CdtProducts")]
        [Validation(Required=false)]
        public List<ListCdtProductsResponseBodyCdtProducts> CdtProducts { get; set; }
        public class ListCdtProductsResponseBodyCdtProducts : TeaModel {
            [NameInMap("BillingType")]
            [Validation(Required=false)]
            public string BillingType { get; set; }

            [NameInMap("BusinessRegionId")]
            [Validation(Required=false)]
            public string BusinessRegionId { get; set; }

            [NameInMap("CdtType")]
            [Validation(Required=false)]
            public string CdtType { get; set; }

            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public long? EffectiveTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("SwitchedToCdt")]
            [Validation(Required=false)]
            public bool? SwitchedToCdt { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
