// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillShrinkRequest : TeaModel {
        [NameInMap("ConsigneeAddress")]
        [Validation(Required=false)]
        public string ConsigneeAddressShrink { get; set; }

        [NameInMap("ConsigneeMobile")]
        [Validation(Required=false)]
        public string ConsigneeMobile { get; set; }

        [NameInMap("ConsigneeName")]
        [Validation(Required=false)]
        public string ConsigneeName { get; set; }

        [NameInMap("ConsigneePhone")]
        [Validation(Required=false)]
        public string ConsigneePhone { get; set; }

        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("GoodsInfos")]
        [Validation(Required=false)]
        public string GoodsInfosShrink { get; set; }

        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SendAddress")]
        [Validation(Required=false)]
        public string SendAddressShrink { get; set; }

        [NameInMap("SendMobile")]
        [Validation(Required=false)]
        public string SendMobile { get; set; }

        [NameInMap("SendName")]
        [Validation(Required=false)]
        public string SendName { get; set; }

        [NameInMap("SendPhone")]
        [Validation(Required=false)]
        public string SendPhone { get; set; }

    }

}
