// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListContainerImagesResponseBody : TeaModel {
        [NameInMap("ContainerImages")]
        [Validation(Required=false)]
        public List<ListContainerImagesResponseBodyContainerImages> ContainerImages { get; set; }
        public class ListContainerImagesResponseBodyContainerImages : TeaModel {
            [NameInMap("ContainerImageDescription")]
            [Validation(Required=false)]
            public string ContainerImageDescription { get; set; }

            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            [NameInMap("ContainerImageNamespace")]
            [Validation(Required=false)]
            public string ContainerImageNamespace { get; set; }

            [NameInMap("ContainerImageVersions")]
            [Validation(Required=false)]
            public List<string> ContainerImageVersions { get; set; }

            [NameInMap("ContainerRegistry")]
            [Validation(Required=false)]
            public string ContainerRegistry { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

        }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
