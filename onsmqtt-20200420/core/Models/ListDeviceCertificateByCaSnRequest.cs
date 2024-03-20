// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class ListDeviceCertificateByCaSnRequest : TeaModel {
        [NameInMap("CaSn")]
        [Validation(Required=false)]
        public string CaSn { get; set; }

        [NameInMap("MqttInstanceId")]
        [Validation(Required=false)]
        public string MqttInstanceId { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
