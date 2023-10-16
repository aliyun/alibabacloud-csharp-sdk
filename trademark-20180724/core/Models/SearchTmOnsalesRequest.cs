// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class SearchTmOnsalesRequest : TeaModel {
        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OrderPriceLeft")]
        [Validation(Required=false)]
        public long? OrderPriceLeft { get; set; }

        [NameInMap("OrderPriceRight")]
        [Validation(Required=false)]
        public long? OrderPriceRight { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("QueryAll")]
        [Validation(Required=false)]
        public bool? QueryAll { get; set; }

        [NameInMap("RegLeft")]
        [Validation(Required=false)]
        public int? RegLeft { get; set; }

        [NameInMap("RegRight")]
        [Validation(Required=false)]
        public int? RegRight { get; set; }

        [NameInMap("RegisterNumber")]
        [Validation(Required=false)]
        public string RegisterNumber { get; set; }

        [NameInMap("SortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TopSearch")]
        [Validation(Required=false)]
        public string TopSearch { get; set; }

    }

}
