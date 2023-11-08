// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateAccountRequest : TeaModel {
        [NameInMap("accountAccessKey")]
        [Validation(Required=false)]
        public string AccountAccessKey { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("secretSign")]
        [Validation(Required=false)]
        public string SecretSign { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
