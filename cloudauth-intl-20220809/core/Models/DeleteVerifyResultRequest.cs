// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteVerifyResultRequest : TeaModel {
        [NameInMap("DeleteAfterQuery")]
        [Validation(Required=false)]
        public string DeleteAfterQuery { get; set; }

        [NameInMap("DeleteType")]
        [Validation(Required=false)]
        public string DeleteType { get; set; }

        [NameInMap("TransactionId")]
        [Validation(Required=false)]
        public string TransactionId { get; set; }

    }

}
