// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLRequest : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OrderActionDetail")]
        [Validation(Required=false)]
        public ListSQLReviewOriginSQLRequestOrderActionDetail OrderActionDetail { get; set; }
        public class ListSQLReviewOriginSQLRequestOrderActionDetail : TeaModel {
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }
            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public string SQLReviewResult { get; set; }
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public string CheckStatusResult { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListSQLReviewOriginSQLRequestOrderActionDetailPage Page { get; set; }
            public class ListSQLReviewOriginSQLRequestOrderActionDetailPage : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
