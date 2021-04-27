// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateEdgeDriverRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("DriverName")]
        [Validation(Required=false)]
        public string DriverName { get; set; }

        [NameInMap("DriverProtocol")]
        [Validation(Required=false)]
        public string DriverProtocol { get; set; }

        [NameInMap("Runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        [NameInMap("IsBuiltIn")]
        [Validation(Required=false)]
        public bool? IsBuiltIn { get; set; }

    }

}
