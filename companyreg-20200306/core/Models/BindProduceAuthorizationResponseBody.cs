// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Companyreg20200306.Models
{
    public class BindProduceAuthorizationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public BindProduceAuthorizationResponseBodyData Data { get; set; }
        public class BindProduceAuthorizationResponseBodyData : TeaModel {
            [NameInMap("AuthorizedUserList")]
            [Validation(Required=false)]
            public List<BindProduceAuthorizationResponseBodyDataAuthorizedUserList> AuthorizedUserList { get; set; }
            public class BindProduceAuthorizationResponseBodyDataAuthorizedUserList : TeaModel {
                [NameInMap("AccountValidType")]
                [Validation(Required=false)]
                public int? AccountValidType { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
