// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class UpdatePartnerReservePriceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BiddingId")]
        [Validation(Required=false)]
        public int? BiddingId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PartnerType")]
        [Validation(Required=false)]
        public string PartnerType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReservePrice")]
        [Validation(Required=false)]
        public double? ReservePrice { get; set; }

    }

}
