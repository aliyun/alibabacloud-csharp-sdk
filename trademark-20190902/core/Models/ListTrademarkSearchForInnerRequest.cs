// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class ListTrademarkSearchForInnerRequest : TeaModel {
        [NameInMap("ApplyBeginTime")]
        [Validation(Required=false)]
        public string ApplyBeginTime { get; set; }

        [NameInMap("ApplyEndTime")]
        [Validation(Required=false)]
        public string ApplyEndTime { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("IfPrecision")]
        [Validation(Required=false)]
        public bool? IfPrecision { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("SearchPreference")]
        [Validation(Required=false)]
        public string SearchPreference { get; set; }

        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Umid")]
        [Validation(Required=false)]
        public string Umid { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
