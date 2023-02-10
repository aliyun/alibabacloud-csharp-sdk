// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PublicCreateImageScanTaskRequest : TeaModel {
        [NameInMap("Digests")]
        [Validation(Required=false)]
        public string Digests { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

        [NameInMap("RegistryTypes")]
        [Validation(Required=false)]
        public string RegistryTypes { get; set; }

        [NameInMap("RepoIds")]
        [Validation(Required=false)]
        public string RepoIds { get; set; }

        [NameInMap("RepoNames")]
        [Validation(Required=false)]
        public string RepoNames { get; set; }

        [NameInMap("RepoNamespaces")]
        [Validation(Required=false)]
        public string RepoNamespaces { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
