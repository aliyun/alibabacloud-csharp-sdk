// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDynamicGroupDevicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDynamicGroupDevicesResponseBodyData Data { get; set; }
        public class QueryDynamicGroupDevicesResponseBodyData : TeaModel {
            [NameInMap("SimpleDeviceInfo")]
            [Validation(Required=false)]
            public List<QueryDynamicGroupDevicesResponseBodyDataSimpleDeviceInfo> SimpleDeviceInfo { get; set; }
            public class QueryDynamicGroupDevicesResponseBodyDataSimpleDeviceInfo : TeaModel {
                [NameInMap("ActiveTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                [NameInMap("CategoryKey")]
                [Validation(Required=false)]
                public string CategoryKey { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=false)]
                public string IotId { get; set; }

                [NameInMap("LastOnlineTime")]
                [Validation(Required=false)]
                public string LastOnlineTime { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UtcActiveTime")]
                [Validation(Required=false)]
                public string UtcActiveTime { get; set; }

                [NameInMap("UtcLastOnlineTime")]
                [Validation(Required=false)]
                public string UtcLastOnlineTime { get; set; }

            }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
