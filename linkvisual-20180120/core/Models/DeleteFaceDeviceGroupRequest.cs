// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class DeleteFaceDeviceGroupRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IsolationId")]
        [Validation(Required=false)]
        public string IsolationId { get; set; }

        [NameInMap("DeviceGroupId")]
        [Validation(Required=false)]
        public string DeviceGroupId { get; set; }

    }

}
