// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListDeviceCredentialClientIdResponseBody : TeaModel {
        [NameInMap("DeviceCredentialClientIdList")]
        [Validation(Required=false)]
        public ListDeviceCredentialClientIdResponseBodyDeviceCredentialClientIdList DeviceCredentialClientIdList { get; set; }
        public class ListDeviceCredentialClientIdResponseBodyDeviceCredentialClientIdList : TeaModel {
            [NameInMap("ClientIdList")]
            [Validation(Required=false)]
            public List<string> ClientIdList { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public string PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public string Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
