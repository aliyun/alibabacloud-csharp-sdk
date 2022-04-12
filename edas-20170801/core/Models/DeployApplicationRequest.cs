// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class DeployApplicationRequest : TeaModel {
        [NameInMap("AppEnv")]
        [Validation(Required=false)]
        public string AppEnv { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Batch")]
        [Validation(Required=false)]
        public int? Batch { get; set; }

        [NameInMap("BatchWaitTime")]
        [Validation(Required=false)]
        public int? BatchWaitTime { get; set; }

        [NameInMap("BuildPackId")]
        [Validation(Required=false)]
        public long? BuildPackId { get; set; }

        [NameInMap("ComponentIds")]
        [Validation(Required=false)]
        public string ComponentIds { get; set; }

        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public string DeployType { get; set; }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("Gray")]
        [Validation(Required=false)]
        public bool? Gray { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("PackageVersion")]
        [Validation(Required=false)]
        public string PackageVersion { get; set; }

        [NameInMap("ReleaseType")]
        [Validation(Required=false)]
        public long? ReleaseType { get; set; }

        [NameInMap("TrafficControlStrategy")]
        [Validation(Required=false)]
        public string TrafficControlStrategy { get; set; }

        [NameInMap("WarUrl")]
        [Validation(Required=false)]
        public string WarUrl { get; set; }

    }

}
