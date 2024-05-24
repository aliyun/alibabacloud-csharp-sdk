// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class OAuthCredential : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        [NameInMap("refreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
