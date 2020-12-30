// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribePkgVersionsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PkgVersions")]
        [Validation(Required=false)]
        public DescribePkgVersionsResponseBodyPkgVersions PkgVersions { get; set; }
        public class DescribePkgVersionsResponseBodyPkgVersions : TeaModel {
            [NameInMap("PkgVersion")]
            [Validation(Required=false)]
            public List<DescribePkgVersionsResponseBodyPkgVersionsPkgVersion> PkgVersion { get; set; }
            public class DescribePkgVersionsResponseBodyPkgVersionsPkgVersion : TeaModel {
                public string CreateUsername { get; set; }
                public string AppName { get; set; }
                public long? UpdateTime { get; set; }
                public string PkgVersionLabel { get; set; }
                public long? CreateTime { get; set; }
                public string PackageSource { get; set; }
                public string AppId { get; set; }
                public string PackageETag { get; set; }
                public string PkgVersionId { get; set; }
                public string PkgVersionDescription { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
