// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListClientPluginVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientPluginVersions")]
        [Validation(Required=false)]
        public List<ListClientPluginVersionsResponseBodyClientPluginVersions> ClientPluginVersions { get; set; }
        public class ListClientPluginVersionsResponseBodyClientPluginVersions : TeaModel {
            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=false)]
            public long? VersionCode { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

        }

    }

}
