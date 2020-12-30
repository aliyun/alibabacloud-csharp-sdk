// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SubmitEmailVerificationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExistList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyExistList> ExistList { get; set; }
        public class SubmitEmailVerificationResponseBodyExistList : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class SubmitEmailVerificationResponseBodySuccessList : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class SubmitEmailVerificationResponseBodyFailList : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
