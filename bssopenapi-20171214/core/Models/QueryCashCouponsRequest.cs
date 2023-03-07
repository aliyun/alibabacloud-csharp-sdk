// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryCashCouponsRequest : TeaModel {
        /// <summary>
        /// Specifies whether the voucher takes effect. Valid values:
        /// 
        /// *   true: The voucher takes effect.
        /// *   false: The voucher does not take effect.
        /// </summary>
        [NameInMap("EffectiveOrNot")]
        [Validation(Required=false)]
        public bool? EffectiveOrNot { get; set; }

        /// <summary>
        /// The end time of the validity period of the voucher. Specify the parameter in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2018-08-01T00:00:00Z.
        /// </summary>
        [NameInMap("ExpiryTimeEnd")]
        [Validation(Required=false)]
        public string ExpiryTimeEnd { get; set; }

        /// <summary>
        /// The start time of the validity period of the voucher. Specify the parameter in the yyyy-MM-ddTHH:mm:ssZ format. Example: 2018-08-01T00:00:00Z.
        /// </summary>
        [NameInMap("ExpiryTimeStart")]
        [Validation(Required=false)]
        public string ExpiryTimeStart { get; set; }

    }

}
