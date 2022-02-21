// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DeleteRenderingDevicesResponseBody : TeaModel {
        [NameInMap("FailedIds")]
        [Validation(Required=false)]
        public List<string> FailedIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
