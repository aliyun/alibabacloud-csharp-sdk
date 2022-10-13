// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDevicesByAccountResponseBody : TeaModel {
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public QueryDevicesByAccountResponseBodyDeviceIds DeviceIds { get; set; }
        public class QueryDevicesByAccountResponseBodyDeviceIds : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public List<string> DeviceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
