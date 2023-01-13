// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySolutionDeviceGroupPageResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QuerySolutionDeviceGroupPageResponseData Data { get; set; }
        public class QuerySolutionDeviceGroupPageResponseData : TeaModel {
            [NameInMap("PageId")]
            [Validation(Required=true)]
            public int? PageId { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=true)]
            public int? Total { get; set; }

            [NameInMap("List")]
            [Validation(Required=true)]
            public QuerySolutionDeviceGroupPageResponseDataList List { get; set; }
            public class QuerySolutionDeviceGroupPageResponseDataList : TeaModel {
                [NameInMap("itemName")]
                [Validation(Required=true)]
                public List<QuerySolutionDeviceGroupPageResponseDataListItemName> ItemName { get; set; }
                public class QuerySolutionDeviceGroupPageResponseDataListItemName : TeaModel {
                    [NameInMap("DeviceCount")]
                    [Validation(Required=true)]
                    public long? DeviceCount { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=true)]
                    public long? GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=true)]
                    public long? GmtModified { get; set; }

                    [NameInMap("GroupDesc")]
                    [Validation(Required=true)]
                    public string GroupDesc { get; set; }

                    [NameInMap("GroupId")]
                    [Validation(Required=true)]
                    public string GroupId { get; set; }

                    [NameInMap("GroupName")]
                    [Validation(Required=true)]
                    public string GroupName { get; set; }

                }

            }

        }

    }

}
