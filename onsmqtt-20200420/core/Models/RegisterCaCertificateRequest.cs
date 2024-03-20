// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RegisterCaCertificateRequest : TeaModel {
        [NameInMap("CaContent")]
        [Validation(Required=false)]
        public string CaContent { get; set; }

        [NameInMap("CaName")]
        [Validation(Required=false)]
        public string CaName { get; set; }

        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        [NameInMap("VerificationContent")]
        [Validation(Required=false)]
        public string VerificationContent { get; set; }

    }

}
