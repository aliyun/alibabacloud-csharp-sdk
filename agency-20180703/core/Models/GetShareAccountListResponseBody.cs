// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetShareAccountListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetShareAccountListResponseBodyDataList DataList { get; set; }
        public class GetShareAccountListResponseBodyDataList : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetShareAccountListResponseBodyDataListData> Data { get; set; }
            public class GetShareAccountListResponseBodyDataListData : TeaModel {
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                [NameInMap("CloudAccount")]
                [Validation(Required=false)]
                public string CloudAccount { get; set; }

                [NameInMap("CustomerAccount")]
                [Validation(Required=false)]
                public string CustomerAccount { get; set; }

                [NameInMap("CustomerName")]
                [Validation(Required=false)]
                public string CustomerName { get; set; }

                [NameInMap("CustomerPhone")]
                [Validation(Required=false)]
                public string CustomerPhone { get; set; }

                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public long? ParentUid { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetShareAccountListResponseBodyPageInfo PageInfo { get; set; }
        public class GetShareAccountListResponseBodyPageInfo : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
