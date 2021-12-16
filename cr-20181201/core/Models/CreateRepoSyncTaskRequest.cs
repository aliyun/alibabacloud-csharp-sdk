// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncTaskRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Override")]
        [Validation(Required=false)]
        public bool? Override { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        [NameInMap("TargetNamespace")]
        [Validation(Required=false)]
        public string TargetNamespace { get; set; }

        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        [NameInMap("TargetTag")]
        [Validation(Required=false)]
        public string TargetTag { get; set; }

        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
