// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class GetAuthenticatorRequest : TeaModel {
        /// <summary>
        /// 应用外部Id
        /// </summary>
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// 认证器uuid
        /// </summary>
        [NameInMap("AuthenticatorUuid")]
        [Validation(Required=false)]
        public string AuthenticatorUuid { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
