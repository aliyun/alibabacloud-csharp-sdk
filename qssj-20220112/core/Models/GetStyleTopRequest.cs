// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetStyleTopRequest : TeaModel {
        [NameInMap("BrandNames")]
        [Validation(Required=false)]
        public string BrandNames { get; set; }

        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        [NameInMap("EndingDate")]
        [Validation(Required=false)]
        public string EndingDate { get; set; }

        [NameInMap("EndingPrice")]
        [Validation(Required=false)]
        public string EndingPrice { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        [NameInMap("ShopIds")]
        [Validation(Required=false)]
        public string ShopIds { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public long? SortOrder { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("StartPrice")]
        [Validation(Required=false)]
        public string StartPrice { get; set; }

        [NameInMap("TimeDisplay")]
        [Validation(Required=false)]
        public long? TimeDisplay { get; set; }

    }

}
