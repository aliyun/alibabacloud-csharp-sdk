// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateVolumesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VolumeIds")]
        [Validation(Required=false)]
        public CreateVolumesResponseBodyVolumeIds VolumeIds { get; set; }
        public class CreateVolumesResponseBodyVolumeIds : TeaModel {
            [NameInMap("VolumeId")]
            [Validation(Required=false)]
            public List<string> VolumeId { get; set; }

        }

    }

}
