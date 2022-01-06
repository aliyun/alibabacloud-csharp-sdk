// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySolutionDeviceGroupPageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySolutionDeviceGroupPageResponseBodyData Data { get; set; }
        public class QuerySolutionDeviceGroupPageResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public QuerySolutionDeviceGroupPageResponseBodyDataList List { get; set; }
            public class QuerySolutionDeviceGroupPageResponseBodyDataList : TeaModel {
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public List<QuerySolutionDeviceGroupPageResponseBodyDataListItemName> ItemName { get; set; }
                public class QuerySolutionDeviceGroupPageResponseBodyDataListItemName : TeaModel {
                    [NameInMap("DeviceCount")]
                    [Validation(Required=false)]
                    public long? DeviceCount { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public long? GmtModified { get; set; }

                    [NameInMap("GroupDesc")]
                    [Validation(Required=false)]
                    public string GroupDesc { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                }

            }
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public int? PageId { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
