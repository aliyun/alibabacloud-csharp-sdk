// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            [NameInMap("versionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
