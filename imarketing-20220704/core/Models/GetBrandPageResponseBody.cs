// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetBrandPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBrandPageResponseBodyData Data { get; set; }
        public class GetBrandPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetBrandPageResponseBodyDataList> List { get; set; }
            public class GetBrandPageResponseBodyDataList : TeaModel {
                public string AccountNo { get; set; }
                public string AccountType { get; set; }
                public string Company { get; set; }
                public long? MainId { get; set; }
                public string MainName { get; set; }
                public long? ParentMainId { get; set; }
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public GetBrandPageResponseBodyDataPageInfo PageInfo { get; set; }
            public class GetBrandPageResponseBodyDataPageInfo : TeaModel {
                [NameInMap("Page")]
                [Validation(Required=false)]
                public int? Page { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalNumber")]
                [Validation(Required=false)]
                public int? TotalNumber { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
