// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryAppDeviceListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryAppDeviceListResponseData Data { get; set; }
        public class QueryAppDeviceListResponseData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=true)]
            public List<QueryAppDeviceListResponseDataData> Data { get; set; }
            public class QueryAppDeviceListResponseDataData : TeaModel {
                public string ProductName { get; set; }
                public string ProductKey { get; set; }
                public string DeviceName { get; set; }
                public int? NodeType { get; set; }
                public string Status { get; set; }
                public string ActiveTime { get; set; }
                public string LastOnlineTime { get; set; }
                public string CreateTime { get; set; }
                public long? ChildDeviceCount { get; set; }
                public string UtcActiveTime { get; set; }
                public string UtcLastOnlineTime { get; set; }
                public string UtcCreateTime { get; set; }
            }
        };

    }

}
