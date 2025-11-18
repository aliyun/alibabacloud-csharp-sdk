// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class ChangeDetailRequest : TeaModel {
        /// <summary>
        /// <para>Change order number</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4988430***950</para>
        /// </summary>
        [NameInMap("change_order_num")]
        [Validation(Required=false)]
        public long? ChangeOrderNum { get; set; }

    }

}
