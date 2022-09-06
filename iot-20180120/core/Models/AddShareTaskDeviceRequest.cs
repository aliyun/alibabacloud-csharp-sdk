// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class AddShareTaskDeviceRequest : TeaModel {
        [NameInMap("IotIdList")]
        [Validation(Required=false)]
        public List<string> IotIdList { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ShareTaskId")]
        [Validation(Required=false)]
        public string ShareTaskId { get; set; }

    }

}
