// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class CreateFixedPriceSelectedOrderRequest : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExpectedPrice")]
        [Validation(Required=false)]
        public double? ExpectedPrice { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
