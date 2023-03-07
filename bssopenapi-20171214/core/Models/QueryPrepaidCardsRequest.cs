// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryPrepaidCardsRequest : TeaModel {
        /// <summary>
        /// Specifies whether the prepaid card takes effect. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EffectiveOrNot")]
        [Validation(Required=false)]
        public bool? EffectiveOrNot { get; set; }

        /// <summary>
        /// The end of the expiration time of prepaid cards to query. The value must be in the yyyy-MM-ddTHH:mm:ssZ format.
        /// </summary>
        [NameInMap("ExpiryTimeEnd")]
        [Validation(Required=false)]
        public string ExpiryTimeEnd { get; set; }

        /// <summary>
        /// The start of the expiration time of prepaid cards to query. The value must be in the yyyy-MM-ddTHH:mm:ssZ format.
        /// </summary>
        [NameInMap("ExpiryTimeStart")]
        [Validation(Required=false)]
        public string ExpiryTimeStart { get; set; }

    }

}
