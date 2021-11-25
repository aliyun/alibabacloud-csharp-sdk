// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class GetWebofficeURLResponseBody : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("AccessTokenExpiredTime")]
        [Validation(Required=false)]
        public string AccessTokenExpiredTime { get; set; }

        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("RefreshTokenExpiredTime")]
        [Validation(Required=false)]
        public string RefreshTokenExpiredTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebofficeURL")]
        [Validation(Required=false)]
        public string WebofficeURL { get; set; }

    }

}
