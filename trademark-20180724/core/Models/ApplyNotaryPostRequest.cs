// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ApplyNotaryPostRequest : TeaModel {
        [NameInMap("NotaryOrderId")]
        [Validation(Required=false)]
        public long? NotaryOrderId { get; set; }

        [NameInMap("ReceiverAddress")]
        [Validation(Required=false)]
        public string ReceiverAddress { get; set; }

        [NameInMap("ReceiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

        [NameInMap("ReceiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

    }

}
