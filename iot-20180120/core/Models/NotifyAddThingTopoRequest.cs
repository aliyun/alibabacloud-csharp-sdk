// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class NotifyAddThingTopoRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DeviceListStr")]
        [Validation(Required=false)]
        public string DeviceListStr { get; set; }

        [NameInMap("GwIotId")]
        [Validation(Required=false)]
        public string GwIotId { get; set; }

        [NameInMap("GwProductKey")]
        [Validation(Required=false)]
        public string GwProductKey { get; set; }

        [NameInMap("GwDeviceName")]
        [Validation(Required=false)]
        public string GwDeviceName { get; set; }

    }

}
