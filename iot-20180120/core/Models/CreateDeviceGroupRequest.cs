// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDeviceGroupRequest : TeaModel {
        [NameInMap("GroupDesc")]
        [Validation(Required=false)]
        public string GroupDesc { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SuperGroupId")]
        [Validation(Required=false)]
        public string SuperGroupId { get; set; }

    }

}
