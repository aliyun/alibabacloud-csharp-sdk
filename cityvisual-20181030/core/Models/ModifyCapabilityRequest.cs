// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class ModifyCapabilityRequest : TeaModel {
        [NameInMap("CapabilityName")]
        [Validation(Required=false)]
        public string CapabilityName { get; set; }

        [NameInMap("CapabilityId")]
        [Validation(Required=false)]
        public string CapabilityId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
