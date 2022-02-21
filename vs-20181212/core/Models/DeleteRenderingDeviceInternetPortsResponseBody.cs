// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteRenderingDeviceInternetPortsResponseBody : TeaModel {
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public DeleteRenderingDeviceInternetPortsResponseBodyInstanceIds InstanceIds { get; set; }
        public class DeleteRenderingDeviceInternetPortsResponseBodyInstanceIds : TeaModel {
            [NameInMap("instanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
