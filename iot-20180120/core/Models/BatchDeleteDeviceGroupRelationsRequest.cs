// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchDeleteDeviceGroupRelationsRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("RealTenantId")]
        [Validation(Required=false)]
        public string RealTenantId { get; set; }

        [NameInMap("RealTripartiteKey")]
        [Validation(Required=false)]
        public string RealTripartiteKey { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public List<BatchDeleteDeviceGroupRelationsRequestDevice> Device { get; set; }
        public class BatchDeleteDeviceGroupRelationsRequestDevice : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

        }

    }

}
