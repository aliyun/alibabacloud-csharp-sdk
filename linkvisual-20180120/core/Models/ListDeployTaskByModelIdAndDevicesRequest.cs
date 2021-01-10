// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class ListDeployTaskByModelIdAndDevicesRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public int? ModelId { get; set; }

        [NameInMap("DeviceList")]
        [Validation(Required=false)]
        public List<ListDeployTaskByModelIdAndDevicesRequestDeviceList> DeviceList { get; set; }
        public class ListDeployTaskByModelIdAndDevicesRequestDeviceList : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

        }

    }

}
