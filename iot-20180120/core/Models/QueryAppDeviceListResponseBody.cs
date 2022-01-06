// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryAppDeviceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAppDeviceListResponseBodyData Data { get; set; }
        public class QueryAppDeviceListResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryAppDeviceListResponseBodyDataData> Data { get; set; }
            public class QueryAppDeviceListResponseBodyDataData : TeaModel {
                public string ActiveTime { get; set; }
                public long? ChildDeviceCount { get; set; }
                public string CreateTime { get; set; }
                public string DeviceName { get; set; }
                public string LastOnlineTime { get; set; }
                public int? NodeType { get; set; }
                public string ProductKey { get; set; }
                public string ProductName { get; set; }
                public string Status { get; set; }
                public string UtcActiveTime { get; set; }
                public string UtcCreateTime { get; set; }
                public string UtcLastOnlineTime { get; set; }
            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
