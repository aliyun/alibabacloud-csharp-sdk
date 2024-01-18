// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain_intl20171218.Models
{
    public class SubmitEmailVerificationResponseBody : TeaModel {
        [NameInMap("ExistList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyExistList> ExistList { get; set; }
        public class SubmitEmailVerificationResponseBodyExistList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("FailList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodyFailList> FailList { get; set; }
        public class SubmitEmailVerificationResponseBodyFailList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public List<SubmitEmailVerificationResponseBodySuccessList> SuccessList { get; set; }
        public class SubmitEmailVerificationResponseBodySuccessList : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
