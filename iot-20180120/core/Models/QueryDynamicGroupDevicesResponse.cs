// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDynamicGroupDevicesResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=true)]
        public string NextToken { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDynamicGroupDevicesResponseData Data { get; set; }
        public class QueryDynamicGroupDevicesResponseData : TeaModel {
            [NameInMap("SimpleDeviceInfo")]
            [Validation(Required=true)]
            public List<QueryDynamicGroupDevicesResponseDataSimpleDeviceInfo> SimpleDeviceInfo { get; set; }
            public class QueryDynamicGroupDevicesResponseDataSimpleDeviceInfo : TeaModel {
                [NameInMap("ActiveTime")]
                [Validation(Required=true)]
                public string ActiveTime { get; set; }

                [NameInMap("CategoryKey")]
                [Validation(Required=true)]
                public string CategoryKey { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("IotId")]
                [Validation(Required=true)]
                public string IotId { get; set; }

                [NameInMap("LastOnlineTime")]
                [Validation(Required=true)]
                public string LastOnlineTime { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=true)]
                public string Nickname { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=true)]
                public int? NodeType { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=true)]
                public string ProductName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=true)]
                public string Status { get; set; }

                [NameInMap("UtcActiveTime")]
                [Validation(Required=true)]
                public string UtcActiveTime { get; set; }

                [NameInMap("UtcLastOnlineTime")]
                [Validation(Required=true)]
                public string UtcLastOnlineTime { get; set; }

            }

        }

    }

}
