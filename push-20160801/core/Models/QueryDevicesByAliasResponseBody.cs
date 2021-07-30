// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDevicesByAliasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public QueryDevicesByAliasResponseBodyDeviceIds DeviceIds { get; set; }
        public class QueryDevicesByAliasResponseBodyDeviceIds : TeaModel {
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public List<string> DeviceId { get; set; }
        };

    }

}
