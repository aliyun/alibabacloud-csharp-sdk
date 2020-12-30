// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class DeleteDeviceForInstanceShrinkRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Devices")]
        [Validation(Required=false)]
        public string DevicesShrink { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        [NameInMap("DeleteInstanceFlag")]
        [Validation(Required=false)]
        public bool? DeleteInstanceFlag { get; set; }

        [NameInMap("DeviceCount")]
        [Validation(Required=false)]
        public string DeviceCount { get; set; }

    }

}
