// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Idaas_doraemon20210520.Models
{
    public class CreateAuthenticatorRegistrationResponseBody : TeaModel {
        /// <summary>
        /// 防重放挑战码
        /// </summary>
        [NameInMap("ChallengeBase64")]
        [Validation(Required=false)]
        public string ChallengeBase64 { get; set; }

        /// <summary>
        /// 创建认证器的Options
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public string Options { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
