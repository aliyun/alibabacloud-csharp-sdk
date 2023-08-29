// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trusted_server20200613.Models
{
    public class RegisterMessageRequest : TeaModel {
        [NameInMap("Extensions")]
        [Validation(Required=false)]
        public string Extensions { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("PropertyAffiliation")]
        [Validation(Required=false)]
        public int? PropertyAffiliation { get; set; }

        [NameInMap("PropertyName")]
        [Validation(Required=false)]
        public string PropertyName { get; set; }

        [NameInMap("PropertyPrivateIp")]
        [Validation(Required=false)]
        public string PropertyPrivateIp { get; set; }

        [NameInMap("PropertyPublicIp")]
        [Validation(Required=false)]
        public string PropertyPublicIp { get; set; }

        [NameInMap("PropertyUuid")]
        [Validation(Required=false)]
        public string PropertyUuid { get; set; }

    }

}
