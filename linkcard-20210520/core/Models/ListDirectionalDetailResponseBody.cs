// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class ListDirectionalDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDirectionalDetailResponseBodyData Data { get; set; }
        public class ListDirectionalDetailResponseBodyData : TeaModel {
            [NameInMap("DirectionalGroupId")]
            [Validation(Required=false)]
            public long? DirectionalGroupId { get; set; }
            [NameInMap("DirectionalName")]
            [Validation(Required=false)]
            public string DirectionalName { get; set; }
            [NameInMap("PaginationResult")]
            [Validation(Required=false)]
            public ListDirectionalDetailResponseBodyDataPaginationResult PaginationResult { get; set; }
            public class ListDirectionalDetailResponseBodyDataPaginationResult : TeaModel {
                [NameInMap("List")]
                [Validation(Required=false)]
                public List<ListDirectionalDetailResponseBodyDataPaginationResultList> List { get; set; }
                public class ListDirectionalDetailResponseBodyDataPaginationResultList : TeaModel {
                    [NameInMap("Address")]
                    [Validation(Required=false)]
                    public string Address { get; set; }

                    [NameInMap("AddressType")]
                    [Validation(Required=false)]
                    public string AddressType { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                [NameInMap("PageCount")]
                [Validation(Required=false)]
                public int? PageCount { get; set; }

                [NameInMap("PageNo")]
                [Validation(Required=false)]
                public int? PageNo { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
