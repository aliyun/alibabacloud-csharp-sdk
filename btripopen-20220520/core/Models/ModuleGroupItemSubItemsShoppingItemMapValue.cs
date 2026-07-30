// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleGroupItemSubItemsShoppingItemMapValue : TeaModel {
        /// <summary>
        /// <para>The price provided by the search.</para>
        /// </summary>
        [NameInMap("search_price")]
        [Validation(Required=false)]
        public ModuleGroupItemSubItemsShoppingItemMapValueSearchPrice SearchPrice { get; set; }
        public class ModuleGroupItemSubItemsShoppingItemMapValueSearchPrice : TeaModel {
            /// <summary>
            /// <para>The face value price in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("ticket_price")]
            [Validation(Required=false)]
            public int? TicketPrice { get; set; }

            /// <summary>
            /// <para>The selling price in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120000</para>
            /// </summary>
            [NameInMap("sell_price")]
            [Validation(Required=false)]
            public int? SellPrice { get; set; }

            /// <summary>
            /// <para>The reference tax in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6000</para>
            /// </summary>
            [NameInMap("tax")]
            [Validation(Required=false)]
            public int? Tax { get; set; }

        }

    }

}
