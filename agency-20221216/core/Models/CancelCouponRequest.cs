// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CancelCouponRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501001340370350</para>
        /// </summary>
        [NameInMap("CouponId")]
        [Validation(Required=false)]
        public long? CouponId { get; set; }

    }

}
