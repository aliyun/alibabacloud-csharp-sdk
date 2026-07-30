// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealOrderDetailQueryRequest : TeaModel {
        /// <summary>
        /// <para>The user ID. If organization personnel synchronization is enabled, this is the btripUserId. Otherwise, pass the userId corresponding to the user in the distributor\&quot;s own system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
