// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ReleaseInstanceRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReleaseIgnoreTime")]
        [Validation(Required=false)]
        public bool? ReleaseIgnoreTime { get; set; }

        [NameInMap("ForceDeleteInstance")]
        [Validation(Required=false)]
        public bool? ForceDeleteInstance { get; set; }

    }

}
