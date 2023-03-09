/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20210425.Models
{
    public class CreateCustomerRequest : TeaModel {
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        [NameInMap("CustomerSource")]
        [Validation(Required=false)]
        public string CustomerSource { get; set; }

        [NameInMap("CustomerSubTrade")]
        [Validation(Required=false)]
        public string CustomerSubTrade { get; set; }

        [NameInMap("CustomerTrade")]
        [Validation(Required=false)]
        public string CustomerTrade { get; set; }

        [NameInMap("Nation")]
        [Validation(Required=false)]
        public string Nation { get; set; }

    }

}
