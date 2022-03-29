// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDeviceInfoResponseBody : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public QueryDeviceInfoResponseBodyDeviceInfo DeviceInfo { get; set; }
        public class QueryDeviceInfoResponseBodyDeviceInfo : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
            [NameInMap("DeviceToken")]
            [Validation(Required=false)]
            public string DeviceToken { get; set; }
            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }
            [NameInMap("LastOnlineTime")]
            [Validation(Required=false)]
            public string LastOnlineTime { get; set; }
            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }
            [NameInMap("PushEnabled")]
            [Validation(Required=false)]
            public bool? PushEnabled { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
