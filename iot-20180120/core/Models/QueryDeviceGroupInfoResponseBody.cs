// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryDeviceGroupInfoResponseBodyData Data { get; set; }
        public class QueryDeviceGroupInfoResponseBodyData : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }
            [NameInMap("GroupDesc")]
            [Validation(Required=false)]
            public string GroupDesc { get; set; }
            [NameInMap("DeviceCount")]
            [Validation(Required=false)]
            public int? DeviceCount { get; set; }
            [NameInMap("DeviceActive")]
            [Validation(Required=false)]
            public int? DeviceActive { get; set; }
            [NameInMap("DeviceOnline")]
            [Validation(Required=false)]
            public int? DeviceOnline { get; set; }
        };

    }

}
