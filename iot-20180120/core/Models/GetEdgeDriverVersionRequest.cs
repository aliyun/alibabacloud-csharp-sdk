// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetEdgeDriverVersionRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DriverId")]
        [Validation(Required=true)]
        public string DriverId { get; set; }

        [NameInMap("DriverVersion")]
        [Validation(Required=true)]
        public string DriverVersion { get; set; }

    }

}
