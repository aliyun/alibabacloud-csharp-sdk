// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class UpdateAuthenticatorAttributeRequest : TeaModel {
        /// <summary>
        /// 应用外部Id
        /// </summary>
        [NameInMap("ApplicationExternalId")]
        [Validation(Required=false)]
        public string ApplicationExternalId { get; set; }

        /// <summary>
        /// 认证器名字
        /// </summary>
        [NameInMap("AuthenticatorName")]
        [Validation(Required=false)]
        public string AuthenticatorName { get; set; }

        /// <summary>
        /// 认证器uuid
        /// </summary>
        [NameInMap("AuthenticatorUuid")]
        [Validation(Required=false)]
        public string AuthenticatorUuid { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
