// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ConfirmSampleShippedRequest : TeaModel {
        [NameInMap("BuyerAddress")]
        [Validation(Required=false)]
        public string BuyerAddress { get; set; }

        [NameInMap("BuyerName")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        [NameInMap("BuyerPhoneNumber")]
        [Validation(Required=false)]
        public string BuyerPhoneNumber { get; set; }

        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        [NameInMap("TradeId")]
        [Validation(Required=false)]
        public string TradeId { get; set; }

    }

}
