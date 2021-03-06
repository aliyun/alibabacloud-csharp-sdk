// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceGroupListResponseData Data { get; set; }
        public class QueryDeviceGroupListResponseData : TeaModel {
            [NameInMap("GroupInfo")]
            [Validation(Required=true)]
            public List<QueryDeviceGroupListResponseDataGroupInfo> GroupInfo { get; set; }
            public class QueryDeviceGroupListResponseDataGroupInfo : TeaModel {
                public string GroupId { get; set; }
                public string UtcCreate { get; set; }
                public string GroupName { get; set; }
                public string GroupDesc { get; set; }
            }
        };

    }

}
