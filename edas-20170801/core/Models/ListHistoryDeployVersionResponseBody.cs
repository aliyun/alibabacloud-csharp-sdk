// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListHistoryDeployVersionResponseBody : TeaModel {
        [NameInMap("PackageVersionList")]
        [Validation(Required=false)]
        public ListHistoryDeployVersionResponseBodyPackageVersionList PackageVersionList { get; set; }
        public class ListHistoryDeployVersionResponseBodyPackageVersionList : TeaModel {
            [NameInMap("PackageVersion")]
            [Validation(Required=false)]
            public List<ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion> PackageVersion { get; set; }
            public class ListHistoryDeployVersionResponseBodyPackageVersionListPackageVersion : TeaModel {
                public string Type { get; set; }
                public string PublicUrl { get; set; }
                public long? UpdateTime { get; set; }
                public string Description { get; set; }
                public long? CreateTime { get; set; }
                public string AppId { get; set; }
                public string WarUrl { get; set; }
                public string Id { get; set; }
                public string PackageVersion { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
