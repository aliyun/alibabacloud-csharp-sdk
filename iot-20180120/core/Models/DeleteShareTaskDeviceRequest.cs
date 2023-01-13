// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeleteShareTaskDeviceRequest : TeaModel {
        [NameInMap("IotIdList")]
        [Validation(Required=false)]
        public List<string> IotIdList { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ShareTaskId")]
        [Validation(Required=true)]
        public string ShareTaskId { get; set; }

    }

}
