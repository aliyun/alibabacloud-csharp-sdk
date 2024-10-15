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
            /// <summary>
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

        }

    }

}
