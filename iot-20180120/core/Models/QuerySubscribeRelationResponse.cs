// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySubscribeRelationResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("DeviceDataFlag")]
        [Validation(Required=true)]
        public bool? DeviceDataFlag { get; set; }

        [NameInMap("DeviceLifeCycleFlag")]
        [Validation(Required=true)]
        public bool? DeviceLifeCycleFlag { get; set; }

        [NameInMap("DeviceStatusChangeFlag")]
        [Validation(Required=true)]
        public bool? DeviceStatusChangeFlag { get; set; }

        [NameInMap("DeviceTagFlag")]
        [Validation(Required=true)]
        public bool? DeviceTagFlag { get; set; }

        [NameInMap("DeviceTopoLifeCycleFlag")]
        [Validation(Required=true)]
        public bool? DeviceTopoLifeCycleFlag { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("FoundDeviceListFlag")]
        [Validation(Required=true)]
        public bool? FoundDeviceListFlag { get; set; }

        [NameInMap("MnsConfiguration")]
        [Validation(Required=true)]
        public string MnsConfiguration { get; set; }

        [NameInMap("OtaEventFlag")]
        [Validation(Required=true)]
        public bool? OtaEventFlag { get; set; }

        [NameInMap("OtaJobFlag")]
        [Validation(Required=true)]
        public bool? OtaJobFlag { get; set; }

        [NameInMap("OtaVersionFlag")]
        [Validation(Required=true)]
        public bool? OtaVersionFlag { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("SubscribeFlags")]
        [Validation(Required=true)]
        public string SubscribeFlags { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ThingHistoryFlag")]
        [Validation(Required=true)]
        public bool? ThingHistoryFlag { get; set; }

        [NameInMap("Type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("ConsumerGroupIds")]
        [Validation(Required=true)]
        public List<string> ConsumerGroupIds { get; set; }

    }

}
