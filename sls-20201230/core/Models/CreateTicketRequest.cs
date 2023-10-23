// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateTicketRequest : TeaModel {
        [NameInMap("playAccessKeyId")]
        [Validation(Required=false)]
        public string PlayAccessKeyId { get; set; }

        [NameInMap("playAccessKeySecret")]
        [Validation(Required=false)]
        public string PlayAccessKeySecret { get; set; }

    }

}
