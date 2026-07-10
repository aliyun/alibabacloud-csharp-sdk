// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemSubItemsShoppingItemMapValue : TeaModel {
        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleGroupItemSubItemsShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleGroupItemSubItemsShoppingItemMapValueSearchPrice : TeaModel {
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

        }

    }

}
