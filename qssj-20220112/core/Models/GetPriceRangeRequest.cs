// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetPriceRangeRequest : TeaModel {
        [NameInMap("BrandNames")]
        [Validation(Required=false)]
        public string BrandNames { get; set; }

        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        [NameInMap("EndingDate")]
        [Validation(Required=false)]
        public string EndingDate { get; set; }

        [NameInMap("Section")]
        [Validation(Required=false)]
        public long? Section { get; set; }

        [NameInMap("ShopIds")]
        [Validation(Required=false)]
        public string ShopIds { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
