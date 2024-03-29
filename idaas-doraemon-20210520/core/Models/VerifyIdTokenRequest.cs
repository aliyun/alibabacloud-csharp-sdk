// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class VerifyIdTokenRequest : TeaModel {
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// jwtIdToken
        /// </summary>
        [NameInMap("JwtIdToken")]
        [Validation(Required=false)]
        public string JwtIdToken { get; set; }

    }

}
