// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceGroupInfoResponse : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryDeviceGroupInfoResponseData Data { get; set; }
        public class QueryDeviceGroupInfoResponseData : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=true)]
            public string GroupId { get; set; }
            [NameInMap("UtcCreate")]
            [Validation(Required=true)]
            public string UtcCreate { get; set; }
            [NameInMap("GroupName")]
            [Validation(Required=true)]
            public string GroupName { get; set; }
            [NameInMap("GroupDesc")]
            [Validation(Required=true)]
            public string GroupDesc { get; set; }
            [NameInMap("DeviceCount")]
            [Validation(Required=true)]
            public int? DeviceCount { get; set; }
            [NameInMap("DeviceActive")]
            [Validation(Required=true)]
            public int? DeviceActive { get; set; }
            [NameInMap("DeviceOnline")]
            [Validation(Required=true)]
            public int? DeviceOnline { get; set; }
        };

    }

}
