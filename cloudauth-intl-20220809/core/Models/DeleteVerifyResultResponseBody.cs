// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DeleteVerifyResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteVerifyResultResponseBodyResult Result { get; set; }
        public class DeleteVerifyResultResponseBodyResult : TeaModel {
            [NameInMap("DeleteResult")]
            [Validation(Required=false)]
            public string DeleteResult { get; set; }

            [NameInMap("TransactionId")]
            [Validation(Required=false)]
            public string TransactionId { get; set; }

        }

    }

}
