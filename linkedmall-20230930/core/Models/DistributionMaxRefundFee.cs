// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class DistributionMaxRefundFee : TeaModel {
        /// <summary>
        /// <para>Maximum refundable amount for this order</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("maxRefundFee")]
        [Validation(Required=false)]
        public long? MaxRefundFee { get; set; }

        /// <summary>
        /// <para>Minimum refundable amount for this order</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minRefundFee")]
        [Validation(Required=false)]
        public long? MinRefundFee { get; set; }

    }

}
