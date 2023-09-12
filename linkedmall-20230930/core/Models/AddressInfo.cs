/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class AddressInfo : TeaModel {
        [NameInMap("addressDetail")]
        [Validation(Required=false)]
        public string AddressDetail { get; set; }

        [NameInMap("addressId")]
        [Validation(Required=false)]
        public long? AddressId { get; set; }

        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        [NameInMap("receiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        [NameInMap("townDivisionCode")]
        [Validation(Required=false)]
        public string TownDivisionCode { get; set; }

    }

}
