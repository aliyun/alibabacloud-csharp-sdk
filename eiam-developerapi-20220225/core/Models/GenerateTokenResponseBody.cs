// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class GenerateTokenResponseBody : TeaModel {
        /// <summary>
        /// access_token。
        /// </summary>
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("expires_at")]
        [Validation(Required=false)]
        public long? ExpiresAt { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long? ExpiresIn { get; set; }

        /// <summary>
        /// id_token。
        /// </summary>
        [NameInMap("id_token")]
        [Validation(Required=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// refresh_token。
        /// </summary>
        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
