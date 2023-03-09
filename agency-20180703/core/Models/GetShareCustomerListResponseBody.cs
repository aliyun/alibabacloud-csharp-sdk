// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetShareCustomerListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetShareCustomerListResponseBodyDataList DataList { get; set; }
        public class GetShareCustomerListResponseBodyDataList : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<GetShareCustomerListResponseBodyDataListData> Data { get; set; }
            public class GetShareCustomerListResponseBodyDataListData : TeaModel {
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                [NameInMap("CustomerAccounts")]
                [Validation(Required=false)]
                public GetShareCustomerListResponseBodyDataListDataCustomerAccounts CustomerAccounts { get; set; }
                public class GetShareCustomerListResponseBodyDataListDataCustomerAccounts : TeaModel {
                    [NameInMap("CustomerAccount")]
                    [Validation(Required=false)]
                    public List<string> CustomerAccount { get; set; }

                }

                [NameInMap("CustomerName")]
                [Validation(Required=false)]
                public string CustomerName { get; set; }

                [NameInMap("CustomerType")]
                [Validation(Required=false)]
                public int? CustomerType { get; set; }

                [NameInMap("CustomerUids")]
                [Validation(Required=false)]
                public GetShareCustomerListResponseBodyDataListDataCustomerUids CustomerUids { get; set; }
                public class GetShareCustomerListResponseBodyDataListDataCustomerUids : TeaModel {
                    [NameInMap("CustomerUid")]
                    [Validation(Required=false)]
                    public List<string> CustomerUid { get; set; }

                }

                [NameInMap("ExitOnGoingProject")]
                [Validation(Required=false)]
                public string ExitOnGoingProject { get; set; }

                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public long? ParentUid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetShareCustomerListResponseBodyPageInfo PageInfo { get; set; }
        public class GetShareCustomerListResponseBodyPageInfo : TeaModel {
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
