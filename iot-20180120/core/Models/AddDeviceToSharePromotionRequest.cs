// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class AddDeviceToSharePromotionRequest : TeaModel {
        [NameInMap("DeviceSimpleInfoList")]
        [Validation(Required=false)]
        public List<AddDeviceToSharePromotionRequestDeviceSimpleInfoList> DeviceSimpleInfoList { get; set; }
        public class AddDeviceToSharePromotionRequestDeviceSimpleInfoList : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

        }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("SharePromotionActivityId")]
        [Validation(Required=false)]
        public string SharePromotionActivityId { get; set; }

        [NameInMap("ShareTaskCode")]
        [Validation(Required=false)]
        public string ShareTaskCode { get; set; }

    }

}
