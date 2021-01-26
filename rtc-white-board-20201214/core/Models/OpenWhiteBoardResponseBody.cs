// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class OpenWhiteBoardResponseBody : TeaModel {
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
        public OpenWhiteBoardResponseBodyResult Result { get; set; }
        public class OpenWhiteBoardResponseBodyResult : TeaModel {
            [NameInMap("DocumentAccessInfo")]
            [Validation(Required=false)]
            public OpenWhiteBoardResponseBodyResultDocumentAccessInfo DocumentAccessInfo { get; set; }
            public class OpenWhiteBoardResponseBodyResultDocumentAccessInfo : TeaModel {
                [NameInMap("AccessToken")]
                [Validation(Required=false)]
                public string AccessToken { get; set; }

                [NameInMap("CollabHost")]
                [Validation(Required=false)]
                public string CollabHost { get; set; }

                [NameInMap("Permission")]
                [Validation(Required=false)]
                public long? Permission { get; set; }

                [NameInMap("UserInfo")]
                [Validation(Required=false)]
                public OpenWhiteBoardResponseBodyResultDocumentAccessInfoUserInfo UserInfo { get; set; }
                public class OpenWhiteBoardResponseBodyResultDocumentAccessInfoUserInfo : TeaModel {
                    [NameInMap("AvatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }
                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }
                    [NameInMap("NickPinyin")]
                    [Validation(Required=false)]
                    public string NickPinyin { get; set; }
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }
                };

            }
        };

    }

}
