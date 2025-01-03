// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class ListExperimentsRequest : TeaModel {
        /// <summary>
        /// <para>Order</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public int? Order { get; set; }

        /// <summary>
        /// <para>Plan ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>189</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

    }

}
