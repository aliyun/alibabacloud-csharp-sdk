// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryShrinkRequest : TeaModel {
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public string ConsigneeInfoShrink { get; set; }

        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public string SenderInfoShrink { get; set; }

    }

}
