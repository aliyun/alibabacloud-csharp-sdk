// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class TransferStorageOrderRequest : TeaModel {
        [NameInMap("DstIotId")]
        [Validation(Required=false)]
        public string DstIotId { get; set; }

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

        [NameInMap("PreRecordDuration")]
        [Validation(Required=false)]
        public int? PreRecordDuration { get; set; }

        [NameInMap("SrcIotId")]
        [Validation(Required=false)]
        public string SrcIotId { get; set; }

        [NameInMap("SrcOrderId")]
        [Validation(Required=false)]
        public string SrcOrderId { get; set; }

        [NameInMap("SupportCrossIdentityTransfer")]
        [Validation(Required=false)]
        public bool? SupportCrossIdentityTransfer { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
