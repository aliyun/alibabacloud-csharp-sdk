// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoBuildRuleRequest : TeaModel {
        [NameInMap("DockerfileLocation")]
        [Validation(Required=false)]
        public string DockerfileLocation { get; set; }

        [NameInMap("DockerfileName")]
        [Validation(Required=false)]
        public string DockerfileName { get; set; }

        [NameInMap("ImageTag")]
        [Validation(Required=false)]
        public string ImageTag { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PushName")]
        [Validation(Required=false)]
        public string PushName { get; set; }

        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
