// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class GetUserProfileCallbackResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseSuccess")]
        [Validation(Required=false)]
        public bool? ResponseSuccess { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetUserProfileCallbackResponseBodyResult Result { get; set; }
        public class GetUserProfileCallbackResponseBodyResult : TeaModel {
            [NameInMap("UserProfileList")]
            [Validation(Required=false)]
            public List<GetUserProfileCallbackResponseBodyResultUserProfileList> UserProfileList { get; set; }
            public class GetUserProfileCallbackResponseBodyResultUserProfileList : TeaModel {
                public string UserId { get; set; }
                public string AvatarUrl { get; set; }
                public string Nick { get; set; }
                public string NickPinyin { get; set; }
            }
        };

    }

}
