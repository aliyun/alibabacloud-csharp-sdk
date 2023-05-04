// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindBatchAxgResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretBindList")]
        [Validation(Required=false)]
        public BindBatchAxgResponseBodySecretBindList SecretBindList { get; set; }
        public class BindBatchAxgResponseBodySecretBindList : TeaModel {
            [NameInMap("SecretBind")]
            [Validation(Required=false)]
            public List<BindBatchAxgResponseBodySecretBindListSecretBind> SecretBind { get; set; }
            public class BindBatchAxgResponseBodySecretBindListSecretBind : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Extension")]
                [Validation(Required=false)]
                public string Extension { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("PhoneNoA")]
                [Validation(Required=false)]
                public string PhoneNoA { get; set; }

                [NameInMap("SecretNo")]
                [Validation(Required=false)]
                public string SecretNo { get; set; }

                [NameInMap("SubsId")]
                [Validation(Required=false)]
                public string SubsId { get; set; }

            }

        }

    }

}
