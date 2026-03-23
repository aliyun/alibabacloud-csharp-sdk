// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckBackupEncryptionAuthorizedResponseBody : TeaModel {
        [NameInMap("AuthorizationState")]
        [Validation(Required=false)]
        public string AuthorizationState { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

    }

}
