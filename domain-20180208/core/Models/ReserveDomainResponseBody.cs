// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class ReserveDomainResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12080761</para>
        /// </summary>
        [NameInMap("AuctionId")]
        [Validation(Required=false)]
        public string AuctionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64F63E07-3AF6-4D59-8616-55DF1A9E03ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
