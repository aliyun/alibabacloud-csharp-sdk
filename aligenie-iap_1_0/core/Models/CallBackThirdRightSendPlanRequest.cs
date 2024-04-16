// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieiap_1_0.Models
{
    public class CallBackThirdRightSendPlanRequest : TeaModel {
        [NameInMap("BizGroup")]
        [Validation(Required=false)]
        public string BizGroup { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CardType")]
        [Validation(Required=false)]
        public int? CardType { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendInfo { get; set; }

        [NameInMap("GenieOpenId")]
        [Validation(Required=false)]
        public string GenieOpenId { get; set; }

        [NameInMap("ReceiveStatus")]
        [Validation(Required=false)]
        public int? ReceiveStatus { get; set; }

        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        [NameInMap("SupplierId")]
        [Validation(Required=false)]
        public long? SupplierId { get; set; }

    }

}
