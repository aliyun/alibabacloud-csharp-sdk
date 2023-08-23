// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class FindUserlistToAuthLoginWithPhoneNumberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("DataObj")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj DataObj { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyDataObj : TeaModel {
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult Result { get; set; }
        public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResult : TeaModel {
            [NameInMap("UserListToAuthLogin")]
            [Validation(Required=false)]
            public List<FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin> UserListToAuthLogin { get; set; }
            public class FindUserlistToAuthLoginWithPhoneNumberResponseBodyResultUserListToAuthLogin : TeaModel {
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("EncryptedUserIdentifier")]
                [Validation(Required=false)]
                public string EncryptedUserIdentifier { get; set; }

                [NameInMap("FindingType")]
                [Validation(Required=false)]
                public string FindingType { get; set; }

                [NameInMap("Nickname")]
                [Validation(Required=false)]
                public string Nickname { get; set; }

                [NameInMap("UserType")]
                [Validation(Required=false)]
                public string UserType { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
