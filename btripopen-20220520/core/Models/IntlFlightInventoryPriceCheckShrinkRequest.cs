// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckShrinkRequest : TeaModel {
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public string PassengerListShrink { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
