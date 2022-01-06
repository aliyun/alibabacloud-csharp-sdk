// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateSubscribeRelationRequest : TeaModel {
        [NameInMap("ConsumerGroupIds")]
        [Validation(Required=false)]
        public List<string> ConsumerGroupIds { get; set; }

        [NameInMap("DeviceDataFlag")]
        [Validation(Required=false)]
        public bool? DeviceDataFlag { get; set; }

        [NameInMap("DeviceLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceLifeCycleFlag { get; set; }

        [NameInMap("DeviceStatusChangeFlag")]
        [Validation(Required=false)]
        public bool? DeviceStatusChangeFlag { get; set; }

        [NameInMap("DeviceTagFlag")]
        [Validation(Required=false)]
        public bool? DeviceTagFlag { get; set; }

        [NameInMap("DeviceTopoLifeCycleFlag")]
        [Validation(Required=false)]
        public bool? DeviceTopoLifeCycleFlag { get; set; }

        [NameInMap("FoundDeviceListFlag")]
        [Validation(Required=false)]
        public bool? FoundDeviceListFlag { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("MnsConfiguration")]
        [Validation(Required=false)]
        public string MnsConfiguration { get; set; }

        [NameInMap("OtaEventFlag")]
        [Validation(Required=false)]
        public bool? OtaEventFlag { get; set; }

        [NameInMap("OtaJobFlag")]
        [Validation(Required=false)]
        public bool? OtaJobFlag { get; set; }

        [NameInMap("OtaVersionFlag")]
        [Validation(Required=false)]
        public bool? OtaVersionFlag { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("ThingHistoryFlag")]
        [Validation(Required=false)]
        public bool? ThingHistoryFlag { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
