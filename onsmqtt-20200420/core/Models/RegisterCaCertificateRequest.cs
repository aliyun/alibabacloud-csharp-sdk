// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class RegisterCaCertificateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CaContent")]
        [Validation(Required=false)]
        public string CaContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CaName")]
        [Validation(Required=false)]
        public string CaName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("VerificationContent")]
        [Validation(Required=false)]
        public string VerificationContent { get; set; }

    }

}
