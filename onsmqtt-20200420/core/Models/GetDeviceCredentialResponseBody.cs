// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class GetDeviceCredentialResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceCredential")]
        [Validation(Required=false)]
        public GetDeviceCredentialResponseBodyDeviceCredential DeviceCredential { get; set; }
        public class GetDeviceCredentialResponseBodyDeviceCredential : TeaModel {
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("DeviceAccessKeyId")]
            [Validation(Required=false)]
            public string DeviceAccessKeyId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("DeviceAccessKeySecret")]
            [Validation(Required=false)]
            public string DeviceAccessKeySecret { get; set; }
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
        };

    }

}
