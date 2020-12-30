// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateInstanceInformationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("AgentVersion")]
        [Validation(Required=false)]
        public string AgentVersion { get; set; }

        [NameInMap("PlatformType")]
        [Validation(Required=false)]
        public string PlatformType { get; set; }

        [NameInMap("PlatformName")]
        [Validation(Required=false)]
        public string PlatformName { get; set; }

        [NameInMap("PlatformVersion")]
        [Validation(Required=false)]
        public string PlatformVersion { get; set; }

        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        [NameInMap("ComputerName")]
        [Validation(Required=false)]
        public string ComputerName { get; set; }

        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

    }

}
