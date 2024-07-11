// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOrderDetailV2Request : TeaModel {
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("modify_apply_id")]
        [Validation(Required=false)]
        public string ModifyApplyId { get; set; }

        [NameInMap("need_query_service_fee")]
        [Validation(Required=false)]
        public bool? NeedQueryServiceFee { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("out_modify_apply_id")]
        [Validation(Required=false)]
        public string OutModifyApplyId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

    }

}
