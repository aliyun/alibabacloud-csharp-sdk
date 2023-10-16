// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTmCollectionPageListResponseBody : TeaModel {
        [NameInMap("CurrentPageNum")]
        [Validation(Required=false)]
        public int? CurrentPageNum { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTmCollectionPageListResponseBodyData Data { get; set; }
        public class QueryTmCollectionPageListResponseBodyData : TeaModel {
            [NameInMap("Trademark")]
            [Validation(Required=false)]
            public List<QueryTmCollectionPageListResponseBodyDataTrademark> Trademark { get; set; }
            public class QueryTmCollectionPageListResponseBodyDataTrademark : TeaModel {
                [NameInMap("Classification")]
                [Validation(Required=false)]
                public string Classification { get; set; }

                [NameInMap("Collected")]
                [Validation(Required=false)]
                public bool? Collected { get; set; }

                [NameInMap("CollectionContent")]
                [Validation(Required=false)]
                public string CollectionContent { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                [NameInMap("TmName")]
                [Validation(Required=false)]
                public string TmName { get; set; }

            }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItemNum")]
        [Validation(Required=false)]
        public int? TotalItemNum { get; set; }

        [NameInMap("TotalPageNum")]
        [Validation(Required=false)]
        public int? TotalPageNum { get; set; }

    }

}
