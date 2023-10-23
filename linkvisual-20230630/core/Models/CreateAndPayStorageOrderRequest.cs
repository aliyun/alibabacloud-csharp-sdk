// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class CreateAndPayStorageOrderRequest : TeaModel {
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("Copies")]
        [Validation(Required=false)]
        public int? Copies { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("DeviceNoOwner")]
        [Validation(Required=false)]
        public bool? DeviceNoOwner { get; set; }

        [NameInMap("EnableDefaultPlan")]
        [Validation(Required=false)]
        public bool? EnableDefaultPlan { get; set; }

        [NameInMap("EventRecordDuration")]
        [Validation(Required=false)]
        public int? EventRecordDuration { get; set; }

        [NameInMap("EventRecordProlong")]
        [Validation(Required=false)]
        public bool? EventRecordProlong { get; set; }

        [NameInMap("ImmediateUse")]
        [Validation(Required=false)]
        public bool? ImmediateUse { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("MaxRecordFileDuration")]
        [Validation(Required=false)]
        public int? MaxRecordFileDuration { get; set; }

        [NameInMap("PreRecordDuration")]
        [Validation(Required=false)]
        public int? PreRecordDuration { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
