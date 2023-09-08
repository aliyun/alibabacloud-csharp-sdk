// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetArtifactResponseBody : TeaModel {
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        [NameInMap("ArtifactProperty")]
        [Validation(Required=false)]
        public string ArtifactProperty { get; set; }

        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Progress")]
        [Validation(Required=false)]
        public string Progress { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportRegionIds")]
        [Validation(Required=false)]
        public string SupportRegionIds { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetArtifactResponseBodyTags> Tags { get; set; }
        public class GetArtifactResponseBodyTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
