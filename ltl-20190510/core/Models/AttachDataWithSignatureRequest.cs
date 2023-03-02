// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class AttachDataWithSignatureRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("BusinessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        [NameInMap("IotAuthType")]
        [Validation(Required=false)]
        public string IotAuthType { get; set; }

        [NameInMap("IotDataDigest")]
        [Validation(Required=false)]
        public string IotDataDigest { get; set; }

        [NameInMap("IotId")]
        [Validation(Required=false)]
        public string IotId { get; set; }

        [NameInMap("IotIdServiceProvider")]
        [Validation(Required=false)]
        public string IotIdServiceProvider { get; set; }

        [NameInMap("IotIdSource")]
        [Validation(Required=false)]
        public string IotIdSource { get; set; }

        [NameInMap("IotSignature")]
        [Validation(Required=false)]
        public string IotSignature { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
