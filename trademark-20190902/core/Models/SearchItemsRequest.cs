// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchItemsRequest : TeaModel {
        [NameInMap("ExcludedTags")]
        [Validation(Required=false)]
        public string ExcludedTags { get; set; }

        [NameInMap("ExcludedUids")]
        [Validation(Required=false)]
        public string ExcludedUids { get; set; }

        [NameInMap("FeedsType")]
        [Validation(Required=false)]
        public bool? FeedsType { get; set; }

        [NameInMap("IntCls")]
        [Validation(Required=false)]
        public string IntCls { get; set; }

        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        [NameInMap("Mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PriceLeft")]
        [Validation(Required=false)]
        public string PriceLeft { get; set; }

        [NameInMap("PriceRight")]
        [Validation(Required=false)]
        public string PriceRight { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public string Products { get; set; }

        [NameInMap("RegisterNumber")]
        [Validation(Required=false)]
        public string RegisterNumber { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("TrademarkNameLength")]
        [Validation(Required=false)]
        public int? TrademarkNameLength { get; set; }

        [NameInMap("TrademarkNameType")]
        [Validation(Required=false)]
        public string TrademarkNameType { get; set; }

        [NameInMap("UmId")]
        [Validation(Required=false)]
        public string UmId { get; set; }

    }

}
