// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ActiveDeviceCertificateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CaSn")]
        [Validation(Required=false)]
        public string CaSn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("DeviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

    }

}
