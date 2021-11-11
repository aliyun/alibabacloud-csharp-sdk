// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class RegisterAuthenticatorResponseBody : TeaModel {
        /// <summary>
        /// 认证器UUID
        /// </summary>
        [NameInMap("AuthenticatorUuid")]
        [Validation(Required=false)]
        public string AuthenticatorUuid { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
