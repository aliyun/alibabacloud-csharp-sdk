// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetMainPartPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMainPartPageResponseBodyData Data { get; set; }
        public class GetMainPartPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetMainPartPageResponseBodyDataList> List { get; set; }
            public class GetMainPartPageResponseBodyDataList : TeaModel {
                [NameInMap("AccountTypeList")]
                [Validation(Required=false)]
                public List<GetMainPartPageResponseBodyDataListAccountTypeList> AccountTypeList { get; set; }
                public class GetMainPartPageResponseBodyDataListAccountTypeList : TeaModel {
                    [NameInMap("AccountType")]
                    [Validation(Required=false)]
                    public string AccountType { get; set; }

                    [NameInMap("AccountTypeDesc")]
                    [Validation(Required=false)]
                    public string AccountTypeDesc { get; set; }

                }

                [NameInMap("Company")]
                [Validation(Required=false)]
                public string Company { get; set; }

                [NameInMap("MainId")]
                [Validation(Required=false)]
                public long? MainId { get; set; }

                [NameInMap("MainName")]
                [Validation(Required=false)]
                public string MainName { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public GetMainPartPageResponseBodyDataPageInfo PageInfo { get; set; }
            public class GetMainPartPageResponseBodyDataPageInfo : TeaModel {
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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
